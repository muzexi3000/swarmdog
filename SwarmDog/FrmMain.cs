﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Newtonsoft;
using Newtonsoft.Json;

namespace SwarmDog
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Data data = new Data();
        BeeApi beeApi = new BeeApi();
        bool autoCashout = true;
        bool startMonitor = true;
        string dataFile = Path.Combine(Application.StartupPath, "data.json");
        CancellationToken cancellationToken = new CancellationToken();

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            File.WriteAllText(dataFile, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

        private void IntervalAction()
        {
            var nodes = bsNode.DataSource as List<Node>;
            if (nodes != null)
            {
                foreach (var node in nodes.Where(c => !string.IsNullOrEmpty(c.Ip) && c.Port > 0))
                {
                    try
                    {
                        if (!startMonitor)
                        {
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            GetBasicInfo(node);
                            Cashout(node);
                        }
                    }
                    catch (Exception ex)
                    {
                        node.Remark = ex.Message;
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        private void Cashout(Node node)
        {
            try
            {
                node.Cheques = beeApi.GetCheques(node);
                node.CashoutCheque = new List<BeeServiceModel.GetCashoutResponse>();
                foreach (var receivedPeer in node.Cheques.lastcheques.Where(c => c.lastreceived != null))
                {
                    var cashoutCheque = beeApi.GetCashout(node, receivedPeer.peer);
                    node.CashoutCheque.Add(cashoutCheque);
                    if (autoCashout && cashoutCheque.uncashedAmount > 0)
                    {
                        var response = beeApi.Cashout(node, receivedPeer.peer);
                        if (response != null && !string.IsNullOrEmpty(response.transactionHash))
                        {
                            node.Remark = "兑换2成功,transactionHash：" + response.transactionHash;
                        }
                        else
                        {
                            node.Remark = "兑换2失败";
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                if (data.SkipError)
                {
                    Cashout2(node);
                }
                else
                {
                    node.Remark = "兑换接口异常。" + ex.Message;
                }
            }
        }

        private void Cashout2(Node node)
        {
            try
            {
                node.Settlements = beeApi.GetSettlements(node);
                node.CashoutCheque = new List<BeeServiceModel.GetCashoutResponse>();
                foreach (var receivedPeer in node.Settlements.settlements.Where(c => c.received > 0))
                {
                    if (autoCashout)
                    {
                        var response = beeApi.Cashout(node, receivedPeer.peer);
                        if (response != null && !string.IsNullOrEmpty(response.transactionHash))
                        {
                            node.Remark = "兑换2成功,transactionHash：" + response.transactionHash;
                        }
                        else
                        {
                            node.Remark = "兑换2失败";
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                node.Remark = "兑换2接口异常。" + ex.Message;
            }

        }


        private void GetBasicInfo(Node node)
        {
            try
            {
                node.Peers = beeApi.GetPeers(node);
                node.Address = beeApi.GetAddresses(node);
                var balance = beeApi.GetBalance(node);
                node.TotalBalance = balance.totalBalance;
                node.AvailableBalance = balance.availableBalance;
            }
            catch (Exception ex)
            {
                node.Remark = "获取基础信息异常。" + ex.Message;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(dataFile))
            {
                var dataInFile = JsonConvert.DeserializeObject<Data>(File.ReadAllText(dataFile));
                if (dataInFile != null)
                {
                    data = dataInFile;
                }
            }
            BindConfig();
            this.bsNode.DataSource = data.Nodes;
            new Task(() =>
             {
                 while (!cancellationToken.IsCancellationRequested)
                 {
                     if (!startMonitor)
                     {
                         Thread.Sleep(1000);
                     }
                     else
                     {
                         IntervalAction();
                         this.Invoke(new Action(() =>
                         {
                             this.bsNode.ResetBindings(false);
                             this.tslSummary.Text =
                             $"当前合计：{data.Nodes.Count}个bee节点,{data.Nodes.Sum(c => c.Peers.Count)}个链接节点,{data.Nodes.Sum(c => c.ChequePeers.Count) }个交互节点,{data.Nodes.Sum(c => c.SentChequeCount)}个发送支票,{ data.Nodes.Sum(c => c.ReceivedChequeCount)}个接收支票,接收金额{data.Nodes.Sum(c => c.ReceiveChequeAmount).ToString("N0")},待兑金额:{data.Nodes.Sum(c => c.TotalUncashedAmount).ToString("N0")}";
                             ;
                             this.rtbLog.AppendText($"休眠{data.SleepSeconds}秒" + Environment.NewLine);
                         }));
                         Thread.Sleep(data.SleepSeconds * 1000);
                     }
                 }
             }, cancellationToken, TaskCreationOptions.LongRunning).Start();
            beeApi.LogAction = log => this.Invoke(new Action(() =>
            {
                this.rtbLog.AppendText(log + Environment.NewLine);
                this.rtbLog.ScrollToCaret();
            }));
        }

        private void BindConfig()
        {
            tsbSkipErr.Text = data.SkipError ? "异常中断" : "异常忽略";
        }

        private void tsbCopyNode_Click(object sender, EventArgs e)
        {
            if (bsNode.Current == null)
            {
                return;
            }
            var newNode = JsonConvert.DeserializeObject<Node>(JsonConvert.SerializeObject(bsNode.Current));
            bsNode.Add(newNode);
        }

        private void tsbDeleteNode_Click(object sender, EventArgs e)
        {
            bsNode.RemoveCurrent();
        }

        private void tsbAddNode_Click(object sender, EventArgs e)
        {
            bsNode.AddNew();
        }

        private void grid_RowHeadersWidthChanged(object sender, EventArgs e)
        {

        }

        private void tsbAutoCashout_Click(object sender, EventArgs e)
        {
            autoCashout = !autoCashout;
            tsbAutoCashout.Text = autoCashout ? "取消自动兑换" : "开启自动兑换";
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            if (exportDr.ShowDialog() == DialogResult.OK)
            {
                var fileName = exportDr.FileName;
                using (var sw = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    using (var writer = new CsvWriter(sw))
                    {
                        writer.WriteRecords(data.Nodes);
                        MessageBox.Show("导出成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(fileName);
                    }
                }
            }

        }

        private void tsbStart_Click(object sender, EventArgs e)
        {
            startMonitor = !startMonitor;
            tsbStart.Text = startMonitor ? "停止监控" : "启动监控";
        }

        private void tsbSkipErr_Click(object sender, EventArgs e)
        {
            data.SkipError = !data.SkipError;
            BindConfig();
            SaveData();
        }
    }
}

using SwarmDog.BeeServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace SwarmDog
{
    public class Node : CsvClassMap<Node>
    {
        public String Name { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public GetAddressesResponse Address { get; set; }
        public string Ethereum { get { return Address == null ? string.Empty : Address.ethereum; } }
        public long TotalBalance { get; set; }
        public long AvailableBalance { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public string Remark { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public List<Peer> Peers { get; set; } = new List<Peer>();

        public int PeersCount { get { return Peers == null ? 0 : Peers.Count; } }

        [Newtonsoft.Json.JsonIgnore]
        public ChequeResponse Cheques { get; set; }

        /// <summary>
        /// 有交互的节点
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public List<string> ChequePeers
        {
            get
            {
                return Cheques == null ? (Settlements == null ? new List<string>() : Settlements.settlements.Select(c => c.peer)).ToList() : Cheques.lastcheques.Select(c => c.peer).ToList();
            }
        }
        public int ChequePeersCount { get { return ChequePeers == null ? (Settlements == null ? 0 : Settlements.settlements.Count()) : ChequePeers.Count; } }
        /// <summary>
        /// 发送节点
        /// </summary>
        public int SentChequeCount { get { return Cheques == null ? (Settlements == null ? 0 : Settlements.settlements.Count(c => c.sent > 0)) : Cheques.lastcheques.Where(c => c.lastsent != null).Count(); } }
        /// <summary>
        /// 发送金额
        /// </summary>
        public long SentChequeAmount { get { return Cheques == null ? (Settlements == null ? 0 : Settlements.totalsent) : Cheques.lastcheques.Where(c => c.lastsent != null).Sum(c => c.lastsent.payout); } }

        /// <summary>
        ///  接收节点
        /// </summary>
        public int ReceivedChequeCount
        {
            get
            {
                return Cheques == null ? (Settlements == null ? 0 : Settlements.settlements.Count(c => c.received > 0)) : Cheques.lastcheques.Where(c => c.lastreceived != null).Count();
            }
        }
        public int CashoutChequeCount { get; set; }
        /// <summary>
        /// 接收金额
        /// </summary>
        public long ReceiveChequeAmount { get { return Cheques == null ? (Settlements == null ? 0 : Settlements.totalreceived) : Cheques.lastcheques.Where(c => c.lastreceived != null).Sum(c => c.lastreceived.payout); } }

        [Newtonsoft.Json.JsonIgnore]
        public List<GetCashoutResponse> CashoutCheque { get; set; } = new List<GetCashoutResponse>();
        public long TotalUncashedAmount { get { return CashoutCheque == null ? 0 : CashoutCheque.Sum(c => c.uncashedAmount); } }

        [Newtonsoft.Json.JsonIgnore]
        public GetSettlementResponse Settlements { get; set; }

        /// <summary>
        /// 兑换成功数量
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int CashoutSuccessCount { get { return CashoutSuccess.Count; } }
        [Newtonsoft.Json.JsonIgnore]
        public HashSet<string> CashoutSuccess { get; set; } = new HashSet<string>();
        /// <summary>
        /// 兑换失败
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int CashoutFailCount { get { return CashoutFail.Count; } }
        [Newtonsoft.Json.JsonIgnore]
        public HashSet<string> CashoutFail { get; set; } = new HashSet<string>();
    }
}

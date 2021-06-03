using Newtonsoft.Json;
using SwarmDog.BeeServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace SwarmDog
{
    public class BeeApi
    {
        WebClient webClient = new WebClient();

        public Action<string> LogAction { get; set; } = new Action<string>(txt => { });

        public List<Peer> GetPeers(Node node)
        {
            try
            {
                node.Remark = "获取链接节点";
                var url = $"http://{ node.Ip}:{node.Port}/peers";
                LogAction($"请求接口[获取链接节点]：{url}");
                var data = webClient.DownloadString(url);
                LogAction($"接口响应：{data}");
                return JsonConvert.DeserializeAnonymousType(data, new { Peers = new List<Peer>() })?.Peers;
            }
            catch (Exception ex)
            {
                var err = $"[获取链接节点]接口异常{ex.Message}";
                node.Remark = err;
                LogAction(err);
                throw ex;
            }
        }

        public ChequeResponse GetCheques(Node node)
        {
            try
            {
                node.Remark = "获取支票列表";
                var url = $"http://{ node.Ip}:{node.Port}/chequebook/cheque";
                LogAction($"请求接口[获取支票列表]：{url}");
                var data = webClient.DownloadString(url);
                LogAction($"接口响应：{data}");
                return JsonConvert.DeserializeObject<ChequeResponse>(data);
            }
            catch (Exception ex)
            {
                var err = $"[获取支票列表]接口异常{ex.Message}";
                node.Remark = err;
                LogAction(err);
                throw ex;
            }
        }
        public GetAddressesResponse GetAddresses(Node node)
        {
            try
            {
                node.Remark = "获取地址列表";
                var url = $"http://{ node.Ip}:{node.Port}/addresses";
                LogAction($"请求接口[获取地址列表]：{url}");
                var data = webClient.DownloadString(url);
                LogAction($"接口响应：{data}");
                return JsonConvert.DeserializeObject<GetAddressesResponse>(data);
            }
            catch (Exception ex)
            {
                var err = $"[获取地址列表]接口异常{ex.Message}";
                node.Remark = err;
                LogAction(err);
                throw ex;
            }
        }

        public BalanceReponse GetBalance(Node node)
        {
            try
            {
                node.Remark = "获取余额信息";
                var url = $"http://{ node.Ip}:{node.Port}/chequebook/balance";
                LogAction($"请求接口[获取余额信息]：{url}");
                var data = webClient.DownloadString(url);
                LogAction($"接口响应：{data}");
                return JsonConvert.DeserializeObject<BalanceReponse>(data);
            }
            catch (Exception ex)
            {
                var err = $"[获取余额信息]接口异常{ex.Message}";
                node.Remark = err;
                LogAction(err);
                throw ex;
            }
        }
        public GetCashoutResponse GetCashout(Node node, string receivedPeer)
        {
            try
            {
                node.Remark = "获取兑换信息";
                var url = $"http://{ node.Ip}:{node.Port}/chequebook/cashout/{receivedPeer}";
                LogAction($"请求接口[获取兑换信息]：{url}");
                var data = webClient.DownloadString(url);
                LogAction($"接口响应：{data}");
                return JsonConvert.DeserializeObject<GetCashoutResponse>(data);
            }
            catch (Exception ex)
            {
                var err = $"[获取兑换信息]接口异常{ex.Message}";
                node.Remark = err;
                LogAction(err);
                throw ex;
            }
        }

        public ResponseModel Cashout(Node node, string receivedPeer)
        {
            try
            {
                node.Remark = "执行支票兑换";
                var url = $"http://{ node.Ip}:{node.Port}/chequebook/cashout/{receivedPeer}";
                LogAction($"POST接口[执行支票兑换]：{url}");
                var data = webClient.UploadString(url, string.Empty);
                LogAction($"接口响应：{data}");
                return JsonConvert.DeserializeObject<ResponseModel>(data);
            }
            catch (Exception ex)
            {
                var err = $"[执行支票兑换]接口异常{ex.Message}";
                node.Remark = err;
                LogAction(err);
                throw ex;
            }
        }

    }
}

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
            var url = $"http://{ node.Ip}:{node.Port}/peers";
            LogAction($"请求接口[获取链接节点]：{url}");
            var data = webClient.DownloadString(url);
            LogAction($"接口响应：{data}");
            return JsonConvert.DeserializeAnonymousType(data, new { Peers = new List<Peer>() })?.Peers;
        }

        public ChequeResponse GetCheques(Node node)
        {
            var url = $"http://{ node.Ip}:{node.Port}/chequebook/cheque";
            LogAction($"请求接口[获取支票列表]：{url}");
            var data = webClient.DownloadString(url);
            LogAction($"接口响应：{data}");
            return JsonConvert.DeserializeObject<ChequeResponse>(data);
        }
        public GetAddressesResponse GetAddresses(Node node)
        {
            var url = $"http://{ node.Ip}:{node.Port}/addresses";
            LogAction($"请求接口[获取地址列表]：{url}");
            var data = webClient.DownloadString(url);
            LogAction($"接口响应：{data}");
            return JsonConvert.DeserializeObject<GetAddressesResponse>(data);
        }

        public BalanceReponse GetBalance(Node node)
        {
            var url = $"http://{ node.Ip}:{node.Port}/chequebook/balance";
            LogAction($"请求接口[获取余额信息]：{url}");
            var data = webClient.DownloadString(url);
            LogAction($"接口响应：{data}");
            return JsonConvert.DeserializeObject<BalanceReponse>(data);
        }
        public GetCashoutResponse GetCashout(Node node, string receivedPeer)
        {
            var url = $"http://{ node.Ip}:{node.Port}/chequebook/cashout/{receivedPeer}";
            LogAction($"请求接口[获取兑换信息]：{url}");
            var data = webClient.DownloadString(url);
            LogAction($"接口响应：{data}");
            return JsonConvert.DeserializeObject<GetCashoutResponse>(data);
        }

        public ResponseModel Cashout(Node node, string receivedPeer)
        {
            var url = $"http://{ node.Ip}:{node.Port}/chequebook/cashout/{receivedPeer}";
            LogAction($"POST接口[执行支票兑换]：{url}");
            var data = webClient.UploadString(url, string.Empty);
            LogAction($"接口响应：{data}");
            return JsonConvert.DeserializeObject<ResponseModel>(data);
        }
    }
}

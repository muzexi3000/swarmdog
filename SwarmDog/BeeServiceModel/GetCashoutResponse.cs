using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog.BeeServiceModel
{
    public class LastCashedCheque
    {
        /// <summary>
        /// 
        /// </summary>
        public string beneficiary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string chequebook { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long payout { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public string recipient { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long lastPayout { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bounced { get; set; }
    }

    public class GetCashoutResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string peer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LastCashedCheque lastCashedCheque { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string transactionHash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Result result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long uncashedAmount { get; set; }
    }
}

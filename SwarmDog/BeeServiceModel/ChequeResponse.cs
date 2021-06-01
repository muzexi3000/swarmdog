using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog.BeeServiceModel
{
    public class Lastreceived
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

    public class Lastsent
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

    public class LastchequesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string peer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Lastreceived lastreceived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Lastsent lastsent { get; set; }
    }

    public class ChequeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<LastchequesItem> lastcheques { get; set; } = new List<LastchequesItem>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog.BeeServiceModel
{
    
    public class SettlementsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string peer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long received { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long sent { get; set; }
    }

    public class GetSettlementResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public long totalreceived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long totalsent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SettlementsItem> settlements { get; set; } = new List<SettlementsItem>();
    }
}

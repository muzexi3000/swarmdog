using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog.BeeServiceModel
{
    public class GetAddressesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string overlay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> underlay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ethereum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string publicKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pssPublicKey { get; set; }
    }
}

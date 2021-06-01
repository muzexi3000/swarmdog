using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog
{
    public class Cashout
    {
        public String TransactionHash { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExecuteTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog
{
    public class Cheque1
    {
        public string SwarmAddress { get; set; }
        public string ChequeBookAddress { get; set; }
        public decimal Amount { get; set; }
        public bool HasCashout { get; set; }
        public bool IsReceived { get; set; }
        public decimal CashoutAmount { get; set; }
    }


}

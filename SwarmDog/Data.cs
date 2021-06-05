using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog
{
    public class Data
    {
        public int SleepSeconds { get; set; } = 10;
        public bool SkipError { get; set; } = false;
        public bool AutoCashout { get; set; } = true;

        public List<Node> Nodes { get; set; } = new List<Node>();

    }
}

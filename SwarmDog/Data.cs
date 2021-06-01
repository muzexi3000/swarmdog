using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwarmDog
{
    public class Data
    {
        public int SleepSeconds { get; set; } = 10;
        public List<int> ColumnWidth { get; set; } = new List<int>();
        public List<Node> Nodes { get; set; } = new List<Node>();
    }
}

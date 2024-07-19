using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class BallSports {
        public string name { get; set; }
        public string teammembers { get; set; }
        public DateTime firstplayed { get; set; }
        public IEnumerable<string> ballsports { get; set; }
    }
}

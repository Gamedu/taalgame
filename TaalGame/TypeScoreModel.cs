using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaalGame
{
    class TypeScoreModel
    {
        public AspNetUser Student { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }
        public int Total { get; set; }
        public DateTime DateTime { get; set; }
    }
}

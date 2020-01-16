using System;

namespace TaalGame
{
    internal class TypeScoreModel
    {
        public AspNetUser Student { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }
        public int Total { get; set; }
        public DateTime DateTime { get; set; }
    }
}
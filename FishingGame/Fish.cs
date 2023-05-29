using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGame
{
    internal class Fish
    {
        public string Name { get; set; }
        public int Point { get; }

        public Fish(string name, int point)
        {
            Name = name;
            Point = point;
        }

        public override string ToString()
        {
            return $"{Name}({Point}pt)";
        }
    }
}

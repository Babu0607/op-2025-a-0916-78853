using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_a_0916_1.Modules
{
    public class SuperHero
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public int Age { get; set; } = 0;

        public override string ToString()
        {
            return $"{Name} is {Alias}";
        }
    }
}
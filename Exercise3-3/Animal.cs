using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public float Age { get; set; }
        public float Weight { get; set; }

        public abstract string DoSound();
        
    }
}

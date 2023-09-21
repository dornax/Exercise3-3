using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Hedgehog : Animal
    {
        public bool Hibernation { get; set; }
        public override string DoSound()
        {
            return "squeal, hiss";
        }
    }
}

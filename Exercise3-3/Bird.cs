using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Bird : Animal
    {
        public float WingSpan { get; set; }

        public override string DoSound()
        {
            return "chirp, whistle";
        }
    }
}

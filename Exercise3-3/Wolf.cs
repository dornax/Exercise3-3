using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Wolf : Animal
    {
        public bool PackAnimal { get; set; }
        public override string DoSound()
        {
            return "howl";
        }
    }
}

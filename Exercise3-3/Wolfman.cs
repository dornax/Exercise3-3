using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Wolfman : Wolf, IPerson
    {
        public string Talk()
        {
            return base.DoSound();
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Horse : Animal
    {

        public string Breed { get; set; }
        public override string DoSound()
        {
            return "neigh";
        }
    }
}

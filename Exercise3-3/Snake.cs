﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_3
{
    internal class Snake : Animal
    {
        public  bool  IsPoisonous { get; set; }
        public override string DoSound()
        {
            return "hiss";
        }
    }
}


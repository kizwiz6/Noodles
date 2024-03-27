﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodles
{
    internal class Pho : Noodle
    {
        public Pho() : base(30.0, 0.64, "flat", "rice flour")
        {

        }

        public String getCookPrep()
        {

            return "Soak pho for 1 hour, then boil for 1 minute in broth. Then garnish with cilantro and jalapeno.";

        }
    }
}

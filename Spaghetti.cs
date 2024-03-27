using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Noodles
{
    internal class Spaghetti : Noodle
    {
        public Spaghetti() : base(30.0, 0.2, "round", "semolina flour")
        {
        }

        public string GetCookPrep()
        {
            return "Boil spaghetti for 8 - 12 minutes and add sauce, cheese, or oil and garlic.";
        }
    }
}

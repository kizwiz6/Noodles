using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noodles
{
    internal class Ramen : Noodle
    {
        public Ramen() : base(30.0, 0.3, "flat", "wheat flour")
        {

        }

    public string GetCookPrep()
    {
        return "Boil ramen for 5 minutes in broth, then add meat, mushrooms, egg, and vegetables.";
    }
}

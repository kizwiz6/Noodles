namespace Noodles
{
    internal class Noodle
    {
        protected double lengthInCentimeters;
        protected double widthInCentimeters;
        protected string shape;
        protected string ingredients;
        protected string texture = "brittle";

        public Noodle(double lenInCent, double wthInCent, string shp, string ingr)
        {
            this.lengthInCentimeters = lenInCent;
            this.widthInCentimeters= wthInCent;
            this.shape = shp;
            this.ingredients = ingr;
        }

        public string getCookPrep()
        {
            return "Boil noodle for 7 minutes and add sauce.";
        }


        static void Main(string[] args)
        {

        }
    }
}

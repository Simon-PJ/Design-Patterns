namespace DesignPatterns.Creational.Builder
{
    class DunePlanetBuilder : AbstractPlanetBuilder
    {
        public override void AddResidents()
        {
            Planet.Residents.Add("Paul Atreides");
            Planet.Residents.Add("Lady Jessica");
        }

        public override void AddWildlife(string name)
        {
            Planet.Wildlife.Add("Muad'dib");
            Planet.Wildlife.Add("Shai-Hulud");
        }

        public override void SetName()
        {
            Planet.Name = "Arrakis";
        }
    }
}

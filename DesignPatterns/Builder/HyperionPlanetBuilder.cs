namespace DesignPatterns.Builder
{
    class HyperionPlanetBuilder : AbstractPlanetBuilder
    {
        public override void AddResidents()
        {
            Planet.Residents.Add("Martin Silenus");
            Planet.Residents.Add("Raul Endymion");
        }

        public override void AddWildlife(string name)
        {
            Planet.Residents.Add("The Shrike");
        }

        public override void SetName()
        {
            Planet.Name = "Hyperion";
        }
    }
}

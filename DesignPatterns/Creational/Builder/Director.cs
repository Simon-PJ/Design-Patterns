namespace DesignPatterns.Creational.Builder
{
    class Director
    {
        public void Build(AbstractPlanetBuilder builder)
        {
            builder.SetName();
            builder.AddResidents();
            builder.AddResidents();
        }
    }
}

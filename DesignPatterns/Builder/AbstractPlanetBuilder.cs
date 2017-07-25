namespace DesignPatterns.Builder
{
    abstract class AbstractPlanetBuilder
    {
        public Planet Planet { get; protected set; }

        public AbstractPlanetBuilder()
        {
            Planet = new Planet();
        }

        public abstract void SetName();

        public abstract void AddResidents();

        public abstract void AddWildlife(string name);
    }
}

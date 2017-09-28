namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Flyweight participant
    /// </summary>
    abstract class StarWarsFilm
    {
        public int Episode { get; set; }

        public abstract string GetPlot();
    }

    /// <summary>
    /// Concrete flyweight participant
    /// </summary>
    class ANewHope : StarWarsFilm
    {
        public override string GetPlot()
        {
            return "Desert planet -> blow up death star";
        }
    }

    /// <summary>
    /// Concrete flyweight participant
    /// </summary>
    class EmpireStrikesBack : StarWarsFilm
    {
        public override string GetPlot()
        {
            return "Hoth -> I am your father";
        }
    }

    /// <summary>
    /// Concrete flyweight participant
    /// </summary>
    class ReturnOfTheJedi : StarWarsFilm
    {
        public override string GetPlot()
        {
            return "Rescue -> blow up death star";
        }
    }
}

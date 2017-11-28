namespace DesignPatterns.Behavioural.Strategy
{
    /// <summary>
    /// Concrete strategy participant
    /// </summary>
    class RegularTravel : ITravelStrategy
    {
        public int GetSpeed()
        {
            return 10000; // Number plucked from thin air
        }
    }
}

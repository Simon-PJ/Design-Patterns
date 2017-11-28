namespace DesignPatterns.Behavioural.Strategy
{
    /// <summary>
    /// Context participant
    /// </summary>
    class MilleniumFalcon
    {
        public ITravelStrategy Strategy { get; set; }

        public int Speed { get; private set; }

        public void Travel()
        {
            Speed = Strategy.GetSpeed();
        }
    }
}

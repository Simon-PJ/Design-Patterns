namespace DesignPatterns.Behavioural.State
{
    /// <summary>
    /// Context participant
    /// </summary>
    class Multivac
    {
        public IExistence State { get; set; }

        public Multivac()
        {
            State = new Matter();
        }

        public string CanTheWorkingsOfTheSecondLawOfThermodynamicBeReversed()
        {
            return State.Answer(this);
        }
    }
}

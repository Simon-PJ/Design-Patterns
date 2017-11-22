namespace DesignPatterns.Behavioural.State
{
    /// <summary>
    /// Concrete state participant
    /// </summary>
    class Hyperspace : IExistence
    {
        public string Answer(Multivac multivac)
        {
            multivac.State = new Matter();

            return "LET THERE BE LIGHT";
        }
    }
}

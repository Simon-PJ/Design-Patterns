namespace DesignPatterns.Behavioural.State
{
    /// <summary>
    /// Concrete state participant
    /// </summary>
    class Matter : IExistence
    {
        public string Answer(Multivac multivac)
        {
            multivac.State = new Hyperspace();

            return "INSUFFICIENT DATA FOR MEANINGFUL ANSWER.";
        }
    }
}

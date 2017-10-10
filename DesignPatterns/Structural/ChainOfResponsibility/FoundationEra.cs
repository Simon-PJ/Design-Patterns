namespace DesignPatterns.Structural.ChainOfResponsibility
{
    /// <summary>
    /// Handler participant
    /// </summary>
    abstract class FoundationEra
    {
        protected FoundationEra NextEra;

        public void SetNextEra(FoundationEra era)
        {
            NextEra = era;
        }

        public abstract void HandleSeldonCrisis(SeldonRecording recording);
    }
}

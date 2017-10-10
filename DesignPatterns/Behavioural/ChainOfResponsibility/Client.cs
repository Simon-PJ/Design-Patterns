namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// Client participant
    /// </summary>
    class Client
    {
        public void HandleEvent()
        {
            var recording = new SeldonRecording(3);

            var encyclopedists = new TheEncyclopedists();
            var mayors = new TheMayors();
            var traders = new TheTraders();

            encyclopedists.SetNextEra(mayors);
            mayors.SetNextEra(traders);

            encyclopedists.HandleSeldonCrisis(recording);
        }
    }
}

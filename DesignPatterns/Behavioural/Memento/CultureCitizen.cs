namespace DesignPatterns.Behavioural.Memento
{
    /// <summary>
    /// Originator participant
    /// </summary>
    class CultureCitizen
    {
        public State State { get; set; }

        public MindState SaveMindState()
        {
            return new MindState
            {
                State = State
            };
        }

        public void RestoreMindState(MindState mindState)
        {
            State = mindState.State;
        }
    }

    public enum State
    {
        Alive,
        Dead
    }
}

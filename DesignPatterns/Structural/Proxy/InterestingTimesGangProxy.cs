namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Proxy participant
    /// </summary>
    class InterestingTimesGangProxy : IInterestingTimesGang
    {
        private InterestingTimesGang _interestingTimesGang;

        public void Intervene()
        {
            if (_interestingTimesGang == null)
            {
                _interestingTimesGang = new InterestingTimesGang();
            }

            _interestingTimesGang.Intervene();
        }
    }
}

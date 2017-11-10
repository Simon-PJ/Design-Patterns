namespace DesignPatterns.Behavioural.Memento
{
    class Client
    {
        public void RestoreMindState()
        {
            var citizen = new CultureCitizen {State = State.Alive};

            var mindState = citizen.SaveMindState();
            var neuralLace = new NeuralLace {LastMindState = mindState};

            // Citizen is killed
            citizen.State = State.Dead;

            // Restore citizen from mindstate
            citizen.RestoreMindState(neuralLace.LastMindState);
        }
    }
}

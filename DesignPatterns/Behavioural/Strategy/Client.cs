using System;

namespace DesignPatterns.Behavioural.Strategy
{
    class Client
    {
        private void PilotFalcon()
        {
            var falcon = new MilleniumFalcon();

            falcon.Strategy = new RegularTravel();
            falcon.Travel();
            Console.WriteLine(falcon.Speed);

            falcon.Strategy = new HyperdriveTravel();
            falcon.Travel();
            Console.WriteLine(falcon.Speed);
        }
    }
}

using System;

namespace DesignPatterns.Behavioural.State
{
    class Client
    {
        public void TheLastQuestion()
        {
            var multivac = new Multivac();

            // Multivac exists as matter in the universe
            var answer = multivac.CanTheWorkingsOfTheSecondLawOfThermodynamicBeReversed();

            // INSUFFICIENT DATA FOR MEANINGFUL ANSWER.
            Console.WriteLine(answer);

            // Multivar exists in hyperspace
            answer = multivac.CanTheWorkingsOfTheSecondLawOfThermodynamicBeReversed();

            // LET THERE BE LIGHT
            Console.WriteLine(answer);
        }
    }
}

using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    /// <summary>
    /// Real subject participant
    /// </summary>
    class InterestingTimesGang : IInterestingTimesGang
    {
        public List<string> Members { get; private set; }

        public InterestingTimesGang()
        {
            // Assembling the interesting times gang is only something we want
            // to do when aboslutely necessary. Hence the use of a proxy.
            Assemble();
        }

        public void Assemble()
        {
            Members = new List<string>
            {
                "Anticipation Of A New Lover's arrival",
                "No Fixed Abode",
                "Star Turn",
                "Tactical Grace",
                "Steely Glint",
                "Serious Callers Only",
                "Shoot Them Later",
                "Different Tan",
                "Not Invented Here",
                "Woetra",
                "Limivorous",
                "Full Refund",
                "End In Tears"
            };
        }

        public void Intervene()
        {
            Console.WriteLine("Intervening on the Outside Context Problem...");
        }
    }
}

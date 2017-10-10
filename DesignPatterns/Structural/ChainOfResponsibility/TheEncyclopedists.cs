using System;

namespace DesignPatterns.Structural.ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler participant
    /// </summary>
    class TheEncyclopedists : FoundationEra
    {
        public override void HandleSeldonCrisis(SeldonRecording recording)
        {
            if (recording.Number == 1)
            {
                Console.Write("Handling balance of power crisis...");
            }
            else if (NextEra != null)
            {
                NextEra.HandleSeldonCrisis(recording);
            }
        }
    }
}

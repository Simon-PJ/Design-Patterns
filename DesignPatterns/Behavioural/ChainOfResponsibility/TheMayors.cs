using System;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler participant
    /// </summary>
    class TheMayors : FoundationEra
    {
        public override void HandleSeldonCrisis(SeldonRecording recording)
        {
            if (recording.Number == 2)
            {
                Console.WriteLine("Handling religion crisis...");
            }
            else if (NextEra != null)
            {
                NextEra.HandleSeldonCrisis(recording);
            }
        }
    }
}

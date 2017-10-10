using System;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    /// <summary>
    /// Concrete handler participant
    /// </summary>
    class TheTraders : FoundationEra
    {
        public override void HandleSeldonCrisis(SeldonRecording recording)
        {
            if (recording.Number == 3)
            {
                Console.WriteLine("Handling trade alone crisis...");
            }
            else if (NextEra != null)
            {
                NextEra.HandleSeldonCrisis(recording);
            }
        }
    }
}

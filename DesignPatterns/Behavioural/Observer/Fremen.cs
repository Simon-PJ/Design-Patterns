using System;

namespace DesignPatterns.Behavioural.Observer
{
    /// <summary>
    /// Concrete subject participant
    /// </summary>
    class Fremen : SandWalker
    {
        public void WalkWhileBreakingStep()
        {
            Console.WriteLine("Walking in irregular pattern, simulating the shifting sand");
        }

        public void WalkInTime()
        {
            Console.WriteLine("Walking in time");

            foreach (var observer in Observers)
            {
                observer.Notify(this);
            }
        }
    }
}

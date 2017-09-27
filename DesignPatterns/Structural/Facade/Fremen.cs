using System;

namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Subsystem particpant
    /// </summary>
    class Fremen
    {
        public void IntegratePaul()
        {
            Console.WriteLine("The Fremen accept Paul Artreides as one of their own");
        }

        public void AttackHarkonnenWithSandWorms()
        {
            Console.WriteLine("The Fremen led by Paul attack the Harkonnen using sandworms");
        }
    }
}

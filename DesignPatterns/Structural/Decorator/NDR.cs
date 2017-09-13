using System;

namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Concrete component participant
    /// </summary>
    class NDR : IRobot
    {
        public void Serve()
        {
            Console.WriteLine("Servicing the Martin family...");
        }
    }
}

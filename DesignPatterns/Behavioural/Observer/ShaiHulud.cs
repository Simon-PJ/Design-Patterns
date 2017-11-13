using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Observer
{
    /// <summary>
    /// Concrete observer participant
    /// </summary>
    class ShaiHulud : ISandListener
    {
        private readonly List<SandWalker> _stomachContents = new List<SandWalker>();

        public void Notify(SandWalker walker)
        {
            Console.WriteLine("Detected something walking on the sand above");

            _stomachContents.Add(walker);
        }
    }
}

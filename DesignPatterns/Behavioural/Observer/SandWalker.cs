using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Observer
{
    /// <summary>
    /// Subject participant
    /// </summary>
    abstract class SandWalker
    {
        protected List<ISandListener> Observers { get; } = new List<ISandListener>();

        public void Attach(ISandListener observer)
        {
            Observers.Add(observer);
        }

        public void Detach(ISandListener observer)
        {
            Observers.Remove(observer);
        }
    }
}

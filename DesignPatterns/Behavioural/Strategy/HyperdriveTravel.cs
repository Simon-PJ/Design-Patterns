using System;

namespace DesignPatterns.Behavioural.Strategy
{
    /// <summary>
    /// Concrete strategy participant
    /// </summary>
    class HyperdriveTravel : ITravelStrategy
    {
        private int _lightSpeed = 299792458;

        public int GetSpeed()
        {
            return Convert.ToInt32(_lightSpeed * 1.5);
        }
    }
}

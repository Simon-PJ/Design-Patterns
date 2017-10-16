using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// Client participant
    /// </summary>
    class Client
    {
        public void JumpSystem()
        {
            var ship = new HeartOfGlass();
            var jarek = new JarekReen();

            var commands = new List<ShipCommand>
            {
                new PrepareBridge(ship),
                new AlertTrafficControl(ship),
                new ContactBeacon(ship)
            };

            jarek.PrepareForJump(commands);
            jarek.JumpToHyperspace();
        }
    }
}

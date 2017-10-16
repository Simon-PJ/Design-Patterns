using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// Invoker participant
    /// </summary>
    class JarekReen
    {
        private List<ShipCommand> _commands = new List<ShipCommand>();

        public void PrepareForJump(List<ShipCommand> preparationSteps)
        {
            _commands = preparationSteps;
        }

        public void JumpToHyperspace()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }

            _commands.Clear();
        }
    }
}

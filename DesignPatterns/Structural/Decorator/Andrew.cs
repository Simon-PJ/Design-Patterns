using System.Collections.Generic;

namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Concrete decorator participant
    /// </summary>
    class Andrew : RobotDecorator
    {
        private readonly List<string> _clothes;

        public Andrew(NDR robot) : base(robot)
        {
            _clothes = new List<string>();
        }

        public void WearClothing(string clothing)
        {
            _clothes.Add(clothing);
        }
    }
}

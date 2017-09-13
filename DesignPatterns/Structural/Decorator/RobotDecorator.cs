namespace DesignPatterns.Structural.Decorator
{
    /// <summary>
    /// Decorator participant
    /// </summary>
    class RobotDecorator : IRobot
    {
        private readonly IRobot _robot;

        public RobotDecorator(IRobot robot)
        {
            _robot = robot;
        }

        public void Serve()
        {
            _robot.Serve();
        }
    }
}

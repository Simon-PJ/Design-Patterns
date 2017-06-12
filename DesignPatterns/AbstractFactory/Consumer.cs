namespace DesignPatterns.AbstractFactory
{
    class Consumer
    {
        private Robot _robot;
        private Ship _ship;

        public Consumer(SciFiFactory abstractFactory)
        {
            _robot = abstractFactory.CreateRobot();
            _ship = abstractFactory.CreateShip();
        }
    }
}

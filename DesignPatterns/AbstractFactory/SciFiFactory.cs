namespace DesignPatterns.AbstractFactory
{
    abstract class SciFiFactory
    {
        public abstract Robot CreateRobot();

        public abstract Ship CreateShip();
    }

    abstract class Robot
    {
    }

    abstract class Ship
    {
    }
}

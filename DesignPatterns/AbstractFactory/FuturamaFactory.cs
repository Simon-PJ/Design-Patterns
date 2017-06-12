namespace DesignPatterns.AbstractFactory
{
    class FuturamaFactory : SciFiFactory
    {
        public override Robot CreateRobot()
        {
            return new Bender();
        }

        public override Ship CreateShip()
        {
            return new PlanetExpressShip();
        }
    }

    class Bender : Robot
    {
    }

    class PlanetExpressShip : Ship
    {
    }
}

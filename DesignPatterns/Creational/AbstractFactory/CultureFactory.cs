namespace DesignPatterns.Creational.AbstractFactory
{
    class CultureFactory : SciFiFactory
    {
        public override Robot CreateRobot()
        {
            return new MawhrinSkel();
        }

        public override Ship CreateShip()
        {
            return new MeImCounting();
        }
    }

    class MawhrinSkel : Robot
    {
    }

    class MeImCounting : Ship
    {
    }
}

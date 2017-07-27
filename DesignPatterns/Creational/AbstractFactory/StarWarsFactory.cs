namespace DesignPatterns.Creational.AbstractFactory
{
    class StarWarsFactory : SciFiFactory
    {
        public override Robot CreateRobot()
        {
            return new R2D2();
        }

        public override Ship CreateShip()
        {
            return new MilleniumFalcon();
        }
    }

    class R2D2 : Robot
    {
    }

    class MilleniumFalcon : Ship
    {
    }
}

namespace DesignPatterns.Prototype
{
    class Client
    {
        public void Method()
        {
            var ship1 = new Ship("Killing Time");
            var ship2 = new Ship("Experiencing a Significant Gravitas Shortfall");

            IShipPrototype clone1 = ship1.Clone();
            IShipPrototype clone2 = ship2.Clone();
        }
    }
}

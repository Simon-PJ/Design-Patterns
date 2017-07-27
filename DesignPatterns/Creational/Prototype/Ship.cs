namespace DesignPatterns.Creational.Prototype
{
    class Ship : IShipPrototype
    {
        public string Name { get; }

        public Ship(string name)
        {
            Name = name;
        }

        public IShipPrototype Clone()
        {
            return (IShipPrototype)MemberwiseClone();
        }
    }
}

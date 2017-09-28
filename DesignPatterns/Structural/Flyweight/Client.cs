namespace DesignPatterns.Structural.Flyweight
{
    class Client
    {
        public void GetFilms()
        {
            var factory = new StarWarsFactory();

            var episode4 = factory.Get("ANH");
            var episode7 = factory.Get("ANH");

            // Adding extrinsic state
            episode4.Episode = 4;
            episode7.Episode = 7;
        }
    }
}

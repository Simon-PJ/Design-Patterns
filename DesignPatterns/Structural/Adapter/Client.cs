using System.Linq;

namespace DesignPatterns.Structural.Adapter
{
    class Client
    {
        public void ClientMethod()
        {
            var trilogies = new IStarWarsTrilogy[]
            {
                new OriginalTrilogyAdapter(),
                new PrequelTrilogyAdapter()
            };

            var movies = trilogies.SelectMany(x => x.MakeMovies());
        }
    }
}

namespace DesignPatterns.Structural.Adapter
{
    class OriginalTrilogyAdapter : IStarWarsTrilogy
    {
        private readonly OriginalTrilogy _trilogy = new OriginalTrilogy();

        public string[] MakeMovies()
        {
            return _trilogy.MakeGoodMovies();
        }
    }
}

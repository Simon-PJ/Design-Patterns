namespace DesignPatterns.Structural.Adapter
{
    class PrequelTrilogyAdapter : IStarWarsTrilogy
    {
        private readonly PrequelTrilogy _trilogy = new PrequelTrilogy();

        public string[] MakeMovies()
        {
            return _trilogy.MakeBadMovies();
        }
    }
}

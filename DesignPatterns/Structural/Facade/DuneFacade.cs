namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Facade participant
    /// </summary>
    class DuneFacade
    {
        private readonly HouseArtreides _houseArtreides;
        private readonly HouseHarkonnen _houseHarkonnen;
        private readonly Fremen _fremen;


        public DuneFacade(HouseArtreides houseArtreides, HouseHarkonnen houseHarkonnen, Fremen fremen)
        {
            _houseArtreides = houseArtreides;
            _houseHarkonnen = houseHarkonnen;
            _fremen = fremen;
        }

        public void RunPlot()
        {
            _houseArtreides.ReceiveArrakis();
            _houseHarkonnen.RetakeArrakis();
            _fremen.IntegratePaul();
            _fremen.AttackHarkonnenWithSandWorms();
            _houseArtreides.ReceiveArrakis();
        }
    }
}

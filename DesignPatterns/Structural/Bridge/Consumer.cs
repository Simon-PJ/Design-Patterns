namespace DesignPatterns.Structural.Bridge
{
    class Consumer
    {
        void ConsumerMethod()
        {
            var scifiBook = new SciFiBook(new IainMBanks());
            var mainstreamBook = new MainstreamBook(new IainBanks());

            scifiBook.Write();
            mainstreamBook.Write();
        }
    }
}

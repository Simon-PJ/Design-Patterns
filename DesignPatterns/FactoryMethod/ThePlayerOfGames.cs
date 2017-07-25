namespace DesignPatterns.FactoryMethod
{
    class ThePlayerOfGames : Story
    {
        protected override void CreateCharacters()
        {
            _characters.Add(new MawhrinSkel());
            _characters.Add(new Gurgeh());
        }
    }
}

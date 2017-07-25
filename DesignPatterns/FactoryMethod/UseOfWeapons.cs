namespace DesignPatterns.FactoryMethod
{
    class UseOfWeapons : Story
    {
        protected override void CreateCharacters()
        {
            _characters.Add(new Zakalwe());
            _characters.Add(new Sma());
        }
    }
}

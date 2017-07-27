using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod
{
    abstract class Story
    {
        protected List<Character> _characters = new List<Character>();

        public Story()
        {
            CreateCharacters();
        }

        protected abstract void CreateCharacters();
    }
}

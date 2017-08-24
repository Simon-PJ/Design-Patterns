using System;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// Leaf participant
    /// </summary>
    class Book : IStory
    {
        private readonly string _name;

        public Book(string name)
        {
            _name = name;
        }

        public void Read()
        {
            Console.WriteLine(_name);
        }
    }
}

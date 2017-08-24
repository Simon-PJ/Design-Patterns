using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    /// <summary>
    /// Composite participant
    /// </summary>
    class Series : IStory
    {
        private readonly List<IStory> _books = new List<IStory>();

        public void Read()
        {
            foreach (var book in _books)
            {
                book.Read();
            }
        }

        public void Add(IStory book)
        {
            _books.Add(book);
        }

        public void Remove(IStory book)
        {
            _books.Remove(book);
        }

        public IStory this[int index] => _books[index];
    }
}

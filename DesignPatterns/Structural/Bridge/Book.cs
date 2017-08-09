using System;

namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Abstraction participant
    /// </summary>
    abstract class Book
    {
        protected IAuthor Author;

        protected Book(IAuthor author)
        {
            Author = author;
        }

        public abstract void Write();
    }

    // Refined abstractions
    class SciFiBook : Book
    {
        public SciFiBook(IAuthor author) : base(author)
        {
        }

        public override void Write()
        {
            Console.WriteLine($"Consider Phlebas by {Author.Name}...");
        }
    }

    class MainstreamBook : Book
    {
        public MainstreamBook(IAuthor author) : base(author)
        {
        }

        public override void Write()
        {
            Console.WriteLine($"The Wasp Factory by {Author.Name}...");
        }
    }
}

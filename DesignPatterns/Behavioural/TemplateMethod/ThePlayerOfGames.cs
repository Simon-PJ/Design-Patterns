using System;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// Concrete class participant
    /// </summary>
    class ThePlayerOfGames : CultureNovel
    {
        public override void ReadBeginning()
        {
            Console.WriteLine("Jernau Morat Gurgeh sets off for the Empire of Azad");
        }

        public override void ReadMiddle()
        {
            Console.WriteLine("Gurgeh plays some games");
        }

        public override void ReadEnd()
        {
            Console.WriteLine("The Culture brings down the Empire of Azad");
        }
    }
}

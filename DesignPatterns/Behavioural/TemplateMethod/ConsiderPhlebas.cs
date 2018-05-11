using System;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// Concrete class participant
    /// </summary>
    class ConsiderPhlebas : CultureNovel
    {
        public override void ReadBeginning()
        {
            Console.WriteLine("Bora Horza Gobuchul is drowning in waste");
        }

        public override void ReadMiddle()
        {
            Console.WriteLine("Horza is chased around by Balveda");
        }

        public override void ReadEnd()
        {
            Console.WriteLine("Everyone dies");
        }
    }
}

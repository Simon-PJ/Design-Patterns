using System;

namespace DesignPatterns.Behavioural.Mediator
{
    /// <summary>
    /// Concrete colleague participant
    /// </summary>
    class JarekReen : BeeveeUser
    {
        public JarekReen(IBeevee beevee) : base(beevee)
        {
        }

        public override void Send(string message)
        {
            Beevee.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Jarek received message: {message}");
        }
    }
}

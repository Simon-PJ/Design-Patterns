using System;

namespace DesignPatterns.Behavioural.Mediator
{
    /// <summary>
    /// Concrete colleague participant
    /// </summary>
    class Minister : BeeveeUser
    {
        public Minister(IBeevee beevee) : base(beevee)
        {
        }

        public override void Send(string message)
        {
            Beevee.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Minister received message: {message}");
        }
    }
}

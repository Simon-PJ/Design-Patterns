namespace DesignPatterns.Behavioural.Mediator
{
    /// <summary>
    /// Colleague participant
    /// </summary>
    abstract class BeeveeUser
    {
        protected IBeevee Beevee;

        public BeeveeUser(IBeevee beevee)
        {
            Beevee = beevee;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}

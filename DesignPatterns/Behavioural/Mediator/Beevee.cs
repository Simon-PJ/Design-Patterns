namespace DesignPatterns.Behavioural.Mediator
{
    /// <summary>
    /// Concrete mediator participant
    /// </summary>
    class Beevee : IBeevee
    {
        public JarekReen Jarek { get; set; }
        public Minister Minister { get; set; }

        public void SendMessage(string message, BeeveeUser sender)
        {
            if (sender == Jarek)
            {
                Minister.Receive(message);
            }
            else if (sender == Minister)
            {
                Jarek.Receive(message);
            }
        }
    }
}

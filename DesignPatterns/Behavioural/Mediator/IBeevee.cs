namespace DesignPatterns.Behavioural.Mediator
{
    /// <summary>
    /// Mediator participant
    /// </summary>
    interface IBeevee
    {
        void SendMessage(string message, BeeveeUser sender);
    }
}

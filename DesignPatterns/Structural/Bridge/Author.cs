namespace DesignPatterns.Structural.Bridge
{
    /// <summary>
    /// Implementor participant
    /// </summary>
    interface IAuthor
    {
        string Name { get; }
    }

    // Concrete implementors
    public class IainBanks : IAuthor
    {
        public string Name => "Iain Banks";
    }

    public class IainMBanks : IAuthor
    {
        public string Name => "Iain M Banks";
    }
}

namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// Command participant
    /// </summary>
    abstract class ShipCommand
    {
        protected HeartOfGlass Ship;

        public abstract void Execute();
    }

    // Concrete command participants

    class PrepareBridge : ShipCommand
    {
        public PrepareBridge(HeartOfGlass ship)
        {
            Ship = ship;
        }

        public override void Execute()
        {
            Ship.PrepareBridge();
        }
    }

    class AlertTrafficControl : ShipCommand
    {
        public AlertTrafficControl(HeartOfGlass ship)
        {
            Ship = ship;
        }

        public override void Execute()
        {
            Ship.AlertTrafficControl();
        }
    }

    class ContactBeacon : ShipCommand
    {
        public ContactBeacon(HeartOfGlass ship)
        {
            Ship = ship;
        }

        public override void Execute()
        {
            Ship.ContactBeacon();
        }
    }
}

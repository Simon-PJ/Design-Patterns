using System;

namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// Receiver participant
    /// </summary>
    class HeartOfGlass
    {
        private BridgeState _bridgeState = BridgeState.Unprepared;
        private readonly TrafficControl _trafficControl = new TrafficControl();
        private bool _isInHyperspace = false;

        public void AlertTrafficControl()
        {
            _trafficControl.Alert();
        }

        public void PrepareBridge()
        {
            _bridgeState = BridgeState.Prepared;
        }

        public void ContactBeacon()
        {
            _isInHyperspace = true;
        }
    }

    enum BridgeState
    {
        Prepared,
        Unprepared
    }

    class TrafficControl
    {
        public void Alert()
        {
            Console.WriteLine("We are going to make the jump");
        }
    }
}

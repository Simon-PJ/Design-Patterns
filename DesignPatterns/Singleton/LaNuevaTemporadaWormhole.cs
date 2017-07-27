namespace DesignPatterns.Singleton
{
    public sealed class LaNuevaTemporadaWormhole
    {
        private static readonly object _lockObject = new object();

        private static LaNuevaTemporadaWormhole _instance;

        private LaNuevaTemporadaWormhole()
        {
        }

        public static LaNuevaTemporadaWormhole Instance
        {
            get
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new LaNuevaTemporadaWormhole();
                    }

                    return _instance;
                }
            }
        }
    }
}

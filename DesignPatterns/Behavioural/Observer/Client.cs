namespace DesignPatterns.Behavioural.Observer
{
    class Client
    {
        public void CrossDesert()
        {
            var shaiHulud = new ShaiHulud();
            var fremen = new Fremen();

            // Shai-Hulud listens for things walking on the surface
            fremen.Attach(shaiHulud);

            // Breaking step masks the fremen's movements from the sand worms
            fremen.WalkWhileBreakingStep();

            // Walking in time alerts the sand worms
            fremen.WalkInTime();
        }
    }
}

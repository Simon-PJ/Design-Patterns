namespace DesignPatterns.Behavioural.Iterator
{
    class Order66
    {
        public void Execute()
        {
            var jediOrder = new JediAggregate();
            var numberOfJedi = 1000;
            for (var i = 0; i < numberOfJedi; i++) jediOrder.Add(new Jedi());

            var iterator = jediOrder.CreateIterator();

            for (var jedi = iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                jedi.Dispose();
            }
        }
    }
}

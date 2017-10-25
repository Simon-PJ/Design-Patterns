namespace DesignPatterns.Behavioural.Iterator
{
    class JediIterator : IJediIterator
    {
        private readonly JediAggregate _jedi;
        private int _current = 0;

        public JediIterator(JediAggregate jedi)
        {
            _jedi = jedi;
        }

        public Jedi First()
        {
            return _jedi[0];
        }

        public Jedi Next()
        {
            _current++;
            return CurrentItem();
        }

        public Jedi CurrentItem()
        {
            return _jedi[_current];
        }

        public bool IsDone()
        {
            return _current >= _jedi.Count;
        }
    }
}

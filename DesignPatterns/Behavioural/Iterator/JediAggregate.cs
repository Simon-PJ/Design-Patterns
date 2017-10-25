using System.Collections;

namespace DesignPatterns.Behavioural.Iterator
{
    class JediAggregate : IJediAggregate
    {
        private ArrayList _jedi;

        public JediAggregate()
        {
            _jedi = new ArrayList();
        }

        public void Add(Jedi jedi)
        {
            _jedi.Add(jedi);
        }

        public IJediIterator CreateIterator()
        {
            return new JediIterator(this);
        }

        public Jedi this[int index] => (Jedi)_jedi[index];

        public int Count => _jedi.Count;
    }
}

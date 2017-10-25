namespace DesignPatterns.Behavioural.Iterator
{
    interface IJediIterator
    {
        Jedi First();
        Jedi Next();
        Jedi CurrentItem();
        bool IsDone();
    }
}

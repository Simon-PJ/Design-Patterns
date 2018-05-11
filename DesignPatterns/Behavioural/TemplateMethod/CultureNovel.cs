namespace DesignPatterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// Abstract class component
    /// </summary>
    abstract class CultureNovel
    {
        public abstract void ReadBeginning();
        public abstract void ReadMiddle();
        public abstract void ReadEnd();

        public void ReadStory()
        {
            ReadBeginning();
            ReadMiddle();
            ReadEnd();
        }
    }
}

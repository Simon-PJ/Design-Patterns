using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    class Client
    {
        public void ReadTheWorksOfIsaacAsimov()
        {
            var theWorksOfIsaacAsimov = new List<IStory>();

            var foundationSeries = new Series();
            foundationSeries.Add(new Book("Foundation"));
            foundationSeries.Add(new Book("Foundation and Empire"));
            foundationSeries.Add(new Book("Second Foundation"));
            theWorksOfIsaacAsimov.Add(foundationSeries);

            var robotSeries = new Series();
            foundationSeries.Add(new Book("The Caves of Steel"));
            foundationSeries.Add(new Book("The Naked Sun"));
            theWorksOfIsaacAsimov.Add(robotSeries);

            theWorksOfIsaacAsimov.Add(new Book("The Last Question"));

            foreach (var workOfIsaacAsimov in theWorksOfIsaacAsimov)
            {
                workOfIsaacAsimov.Read();
            }
        }
    }
}

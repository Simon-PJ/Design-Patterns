using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    class Planet
    {
        public string Name { get; set; }

        public List<string> Residents { get; }

        public List<string> Wildlife { get; }

        public Planet()
        {
            Residents = new List<string>();
            Wildlife = new List<string>();
        }
    }
}

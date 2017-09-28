using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    /// <summary>
    /// Flyweight factory participant
    /// </summary>
    class StarWarsFactory
    {
        private Dictionary<string, StarWarsFilm> _films;

        public StarWarsFactory()
        {
            _films = new Dictionary<string, StarWarsFilm>();
        }

        public StarWarsFilm Get(string key)
        {
            if (_films.ContainsKey(key))
            {
                return _films[key];
            }

            StarWarsFilm film = null;

            switch (key)
            {
                case "ANH":
                    film = new ANewHope();
                    break;
                case "ESB":
                    film = new EmpireStrikesBack();
                    break;
                case "ROTJ":
                    film = new ReturnOfTheJedi();
                    break;
            }

            _films.Add(key, film);
            return film;
        }
    }
}

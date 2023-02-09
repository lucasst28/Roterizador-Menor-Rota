using ProjetoFinal_ED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_ED
{
    public class Map
    {
        public readonly Dictionary<string, City> Cities;

        public Map()
        {
            Cities = new Dictionary<string, City>();
        }

        public City GetCity(string name) => Cities[name];

        public City AddCity(City city)
        {
            string name = city.Name;

            if (Cities.ContainsKey(name))
                return Cities[name];
            else
            {
                Cities.Add(name, city);
                return Cities[name];
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_ED
{
    public class City
    {
        public string Name { get; set; }
        public List<Road> Roads { get; set; }

        public City(string name)
        {
            Name = name;
            Roads = new List<Road>();
        }

        public void AddRoad(City toCity, int length)
        {
            Road road = new Road(toCity, length);
            Roads.Add(road);
        }

        public Road GetRoadTo(City next)
        {
            foreach (Road road in Roads)
            {
                if (road.DestinationCity.Equals(next))
                {
                    return road;
                }
            }
            return null;
        }
    }
}

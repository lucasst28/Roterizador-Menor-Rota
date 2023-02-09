using ProjetoFinal_ED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_ED
{
    public class Road
    {
        public City DestinationCity { get; set; }
        public int Distance { get; set; }

        public Road(City destinationCity, int distance)
        {
            DestinationCity = destinationCity;
            Distance = distance;
        }
    }
}

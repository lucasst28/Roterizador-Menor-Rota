using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_ED
{
    class HeapNode
    {
        public int Position;
        public int Key;
        public City City;
        public HeapNode(int key, City city)
        {
            Key = key;
            City = city;
        }
    }
}

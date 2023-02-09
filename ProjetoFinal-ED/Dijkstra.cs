using ProjetoFinal_ED;
using System.Collections.Generic;

namespace ProjetoFinal_ED
{
    public class Dijkstra
    {
        public static List<City> ShortestPath(Map map, City start, City end)
        {
            // Armazenar o caminho anterior de cada cidade
            Dictionary<City, City> previous = new Dictionary<City, City>();
            // Criar o heap para armazenar as cidades e suas distâncias
            Heap heap = new Heap(map.Cities.Count);

            // Armazenar o caminho final
            List<City> path = new List<City>();

            // Inserir as cidades no heap e definir suas distâncias iniciais
            foreach (City city in map.Cities.Values)
            {
                if (city != start)
                {
                    heap.Insert(new HeapNode(int.MaxValue, city));
                }
                else
                {
                    heap.Insert(new HeapNode(0, city));
                }
            }

            // Enquanto houver cidades no heap
            while (heap.Count > 0)
            {
                // Extrair a cidade com a menor distância
                HeapNode min = heap.ExtractMin();

                // Se a cidade extraída é a cidade de destino, parar o loop
                if (min.City.Name == end.Name)
                {
                    // Construir o caminho usando o dicionário previous
                    while (previous.ContainsKey(min.City))
                    {
                        path.Add(min.City);
                        min.City = previous[min.City];
                    }
                    break;
                }

                // Verificar as cidades conectadas a cidade extraída
                foreach (Road curr in min.City.Roads)
                {
                    string endCityName = curr.DestinationCity.Name;
                    HeapNode endCity = heap.Nodes[heap.GetHeapNodeIndex(endCityName)];

                    int newDistance = min.Key + curr.Distance;
                    // Se houver um caminho mais curto, atualizar a distância e o caminho anterior
                    if (newDistance < endCity.Key)
                    {
                        previous[endCity.City] = min.City;
                        endCity.Key = newDistance;
                        heap.DecreaseKey(endCity);
                    }
                }
            }

            // Adicionar a cidade de início ao caminho final
            path.Add(start);
            // Reverter a ordem do caminho para obter o caminho correto
            path.Reverse();
            return path;
        }
    }
}
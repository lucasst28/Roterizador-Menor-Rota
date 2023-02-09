using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_ED
{
    class Heap
    {
        public HeapNode[] Nodes;
        public Dictionary<string, HeapNode> Names;
        public int Count;

        public Heap(int capacity)
        {
            Nodes = new HeapNode[capacity];
            Count = 0;
            Names = new Dictionary<string, HeapNode>();
        }

        public void Insert(HeapNode node)
        {
            if (Count == Nodes.Length)
                throw new Exception("Capacidade excedeu");

            int position = Count++;
            Nodes[position] = node;
            node.Position = position;

            Names[node.City.Name] = node;

            BubbleUp(position);
        }

        public HeapNode ExtractMin()
        {
            HeapNode min = new HeapNode(Nodes[0].Key, Nodes[0].City);
            Swap(0, Count - 1);
            Count--;
            BubbleDown(0);
            return min;
        }

        public void DecreaseKey(HeapNode node)
        {
            int position = node.Position;
            while ((position > 0) && (Nodes[Parent(position)].Key > node.Key))
            {
                int originalParentPosition = Parent(position);
                Swap(originalParentPosition, position);
                position = originalParentPosition;
            }
        }

        public void BubbleUp(int position)
        {
            while (position > 0 && Nodes[Parent(position)].Key > Nodes[position].Key)
            {
                int originalParentPosition = Parent(position);
                Swap(position, originalParentPosition);
                position = originalParentPosition;
            }
        }

        void BubbleDown(int position)
        {
            int lChild = LeftChild(position);
            int rChild = RightChild(position);
            int largest = 0;

            largest = ((lChild < Count) && (Nodes[lChild].Key < Nodes[position].Key)) ? lChild : position;

            if ((rChild < Count) && (Nodes[rChild].Key < Nodes[largest].Key))
            {
                largest = rChild;
            }

            if (largest != position)
            {
                Swap(position, largest);
                BubbleDown(largest);
            }
        }

        static int Parent(int position) => (position - 1) / 2;
        static int LeftChild(int position) => 2 * position + 1;

        static int RightChild(int position) => 2 * position + 2;

        void Swap(int firstPosition, int secondPosition)
        {
            HeapNode temp = Nodes[firstPosition];
            Nodes[firstPosition] = Nodes[secondPosition];
            Nodes[secondPosition] = temp;

            Nodes[firstPosition].Position = firstPosition;
            Nodes[secondPosition].Position = secondPosition;
        }
        public int GetHeapNodeIndex(string name)
        {
            for (int i = 0; i < Nodes.Length; i++)
            {
                if (Nodes[i].City.Name == Names[name].City.Name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

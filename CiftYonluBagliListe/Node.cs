using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    class Node<T>
    {
        public Node<T> prevNode = null;
        public Node<T> nextNode = null;
        T data;

        public Node(T data, Node<T> prevNode = null, Node<T> nextNode = null)
        {
            this.data = data;
            this.prevNode = prevNode;
            this.nextNode = nextNode;
        }

        public Node() { }

        public T GetData()
        {
            return data;
        }
    }
}

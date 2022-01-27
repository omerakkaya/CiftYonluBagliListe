using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    class LastNode<T> : Node<T>, IPrepend<T>
    {
        public LastNode(T data) : base(data) { }

        public LastNode() { }

        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);

            newNode.prevNode = prevNode;
            prevNode.nextNode = newNode;
            prevNode = newNode;
            newNode.nextNode = this;
        }
    }
}

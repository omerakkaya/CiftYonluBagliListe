using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    class FirstNode<T> : Node<T>, IAppend<T>
    {
        public FirstNode(T data) : base(data) { }

        public FirstNode() { }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);

            newNode.nextNode = nextNode;
            nextNode.prevNode= newNode;
            nextNode = newNode;
            newNode.prevNode = this;
        }
    }
}

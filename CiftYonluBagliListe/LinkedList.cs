using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    class LinkedList<T>
    {
        FirstNode<T> firstNode = new FirstNode<T>();
        LastNode<T> lastNode = new LastNode<T>();

        public LinkedList()
        {
            firstNode.nextNode = lastNode;
            lastNode.prevNode = firstNode;
        }

        public void Append(T data, params T[] nextNodes)
        {
            lastNode.Prepend(data);

            foreach (T paramsData in nextNodes)
            {
                lastNode.Prepend(paramsData);
            }
        }

        public void Prepend(T data, params T[] nextNodes)
        {
            firstNode.Append(data);

            foreach(T paramsData in nextNodes)
            {
                firstNode.Append(paramsData);
            }
        }

        public void RemoveItemFirst(T data)
        {
            Node<T> currentNode = firstNode.nextNode;
            
            while(currentNode != lastNode)
            {
                if (currentNode.GetData().Equals(data))
                {
                    currentNode.prevNode.nextNode = currentNode.nextNode;
                    currentNode.nextNode.prevNode = currentNode.prevNode;
                    break;
                }
                currentNode = currentNode.nextNode;
            }
        }

        public void RemoveItemLast(T data)
        {
            Node<T> currentNode = lastNode.prevNode;
            
            while(currentNode != firstNode)
            {
                if (currentNode.GetData().Equals(data))
                {
                    currentNode.prevNode.nextNode = currentNode.nextNode;
                    currentNode.nextNode.prevNode = currentNode.prevNode;
                    break;
                }
                currentNode = currentNode.prevNode;
            }
        }

        public void RemoveItemAll(T data)
        {
            Node<T> currentNode = firstNode.nextNode;
            
            while(currentNode != lastNode)
            {
                if (currentNode.GetData().Equals(data))
                {
                    currentNode.prevNode.nextNode = currentNode.nextNode;
                    currentNode.nextNode.prevNode = currentNode.prevNode;
                }
                currentNode = currentNode.nextNode;
            }
        }

        public void ReadList()
        {
            Node<T> currentNode = firstNode.nextNode;
            while(currentNode != lastNode)
            {
                Console.WriteLine(currentNode.GetData());
                currentNode = currentNode.nextNode;
            }
        }

        public void ReadListReverse()
        {
            Node<T> currentNode = lastNode.prevNode;
            while(currentNode != firstNode)
            {
                Console.WriteLine(currentNode.GetData());
                currentNode = currentNode.prevNode;
            }
        }

        public bool Include(T data)
        {
            Node<T> currentNode = firstNode.nextNode;

            while(currentNode != lastNode)
            {
                if (currentNode.GetData().Equals(data))
                {
                    return true;
                }
                currentNode = currentNode.nextNode;
            }

            return false;
        }
    }
}

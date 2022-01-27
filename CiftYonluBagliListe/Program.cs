using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for(int i = 0; i < 10; i++)
            {
                linkedList.Append(i);
            }

            linkedList.ReadList();
            Console.ReadKey();
        }
    }
}

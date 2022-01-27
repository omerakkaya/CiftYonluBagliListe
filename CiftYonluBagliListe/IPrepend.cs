using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    internal interface IPrepend<T>
    {
        void Prepend(T data);
    }
}

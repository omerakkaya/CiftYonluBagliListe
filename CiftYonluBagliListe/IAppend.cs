using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftYonluBagliListe
{
    internal interface IAppend<T>
    {
        void Append(T data);
    }
}

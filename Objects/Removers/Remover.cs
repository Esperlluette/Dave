using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dave.Objects.Removers
{
    public abstract class Remover<T>
    {
        public abstract void Remove(T obj);
    }
}

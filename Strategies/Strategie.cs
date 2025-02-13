using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dave.Objects.Removers;

namespace Dave.Strategies
{
    public enum Subject
    {
        FileSystem,
        Mails
    }
    public abstract class Strategie
    {
        public required Remover<Type> Remover;
        public required List<string> Bin;
    }
}

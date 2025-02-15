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
    public abstract class Strategie<T>
    {
        public Subject subject;
        public Remover<T>? Remover;
        public List<string> Bin = new List<string>();

        public abstract void AddToBin();
        public abstract bool SatisfiesPredicate(T obj);
    }
}

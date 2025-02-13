using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dave.Objects.Removers;
using Dave.Strategies;

namespace Dave.Objects.Agents
{
    public abstract class Agent<T>
    {
        public Strategie<T> strategie;
        public Agent(Strategie<T> strategie)
        {
            this.strategie = strategie;
        }
        public abstract void Crawl();
    }
}

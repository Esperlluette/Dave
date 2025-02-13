using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dave.Objects.Removers;
using Dave.Strategies;

namespace Dave.Objects.Agents
{
    public class Agent
    {
        public required Strategie strategie;
        public Agent(Strategie strategie)
        {
            this.strategie = strategie;
        }
        public void Crawl()
        {
            throw new NotImplementedException();
        }
    }
}

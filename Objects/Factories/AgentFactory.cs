using Dave.Objects.Agents;
using Dave.Objects.Removers;
using Dave.Strategies;

namespace Dave.Objects.Factories
{
    public static class AgentFactory<T>
    {
        public static FileAgent<string> GetFilebasedAgent(Subject subject, string root)
        {
            Remover<string> remover = new FileRemover();
            return
                new FileAgent<string>(
                    new DateStrategie<string>(
                        subject,
                        DateTime.Now,
                        remover,
                        PredicatType.After
                    ), 
                    root
                )
            ;
        }
    }
}

using Dave.Objects.Agents;
using Dave.Objects.Removers;
using Dave.Strategies;

namespace Dave.Objects.Factories
{
    public static class AgentFactory<T>
    {
        public static FileAgent<string> GetFilebasedAgent(Subject subject, string root, DateTime condition)
        {
            Remover<string> remover = new FileRemover();
            return
                new FileAgent<string>(
                    new DateStrategie<string>(
                        subject,
                        condition,
                        remover,
                        PredicatType.After
                    ), 
                    root
                )
            ;
        }
    }
}

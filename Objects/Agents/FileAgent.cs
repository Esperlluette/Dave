using Dave.Strategies;

namespace Dave.Objects.Agents
{
    public class FileAgent<T> : Agent<string>
    {

        public List<string>? fileFromRoot;
        public string? root { get; set; }

        public FileAgent(Strategie<string> strategie, string? root = null) : base(strategie)
        {
            this.root = root;
            GetFileFromRoot();
        }

        public void GetFileFromRoot()
        {
            if (!string.IsNullOrEmpty(root))
            {
                if (!Directory.Exists(root))
                {
                    throw new Exception("Répertoire inexistant");
                }
                fileFromRoot = Directory.GetFiles(root, "*.*", SearchOption.AllDirectories).ToList();
            }
        }

        public override void Crawl()
        {
            switch (strategie.subject)
            {
                case Subject.Mails:
                    break;
                case Subject.FileSystem:
                    var list = this.fileFromRoot?.ToArray() ?? [] ;
                    foreach (var item in list)
                    {
                       if (strategie.SatisfiesPredicate(File.GetLastAccessTime(item).ToString())) {
                            strategie.Remover.Remove(item);
                        }
                    }
                    break;
                default:
                    throw new Exception("Aucun sujet de stratégie choisi.");
            }
        }
    }
}

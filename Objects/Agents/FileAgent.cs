using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    break;
                default:
                    throw new Exception("Aucun sujet de stratégie choisi.");
            }
        }
    }
}

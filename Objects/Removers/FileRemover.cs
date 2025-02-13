using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dave.Objects.Removers
{
    public class FileRemover : Remover<string>
    {
        public FileRemover()
        {
        }

        public override void Remove(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("Fichier inexistant ou non présent.");
            }
        }

    }
}

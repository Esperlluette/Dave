using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NLog;

namespace Dave.Objects.Removers
{
    public class FileRemover : Remover<string>
    {
        public FileRemover()
        {
        }

        public override void Remove(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex) { }
        }

    }
}

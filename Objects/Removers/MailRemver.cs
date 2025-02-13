using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dave.Objects.Removers
{
    public class MailRemver: Remover<MailMessage>
    {
        public MailRemver() { }
        public override void Remove(MailMessage obj)
        {
            throw new NotImplementedException();
        }
    }
}

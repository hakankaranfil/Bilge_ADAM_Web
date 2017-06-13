using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
  public  class Mail
    {
        public int MailID { get; set; }
        public string Sifre { get; set; }
        public string GonderilecekMail { get; set; }
        public string Konu { get; set; }
        public string GondericiMail { get; set; }
        public Menu Menu { get; set; }
        public Customer Customer { get; set; }
        public Admin Admin { get; set; }
        public Product Product { get; set; }

    }
}

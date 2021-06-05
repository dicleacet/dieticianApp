using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class obezHastasi : IHastaliklar
    {
        public string hastalik()
        {
            return "Kişinin tüketebildiğinden fazla kalori almasının sonucunda vücutta normalden fazla yağ depolanmasıdır.";
        }
    }
}

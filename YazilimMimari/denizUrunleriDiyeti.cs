using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class denizUrunleriDiyeti : IDiyetler
    {
        public string diyet()
        {
            return "Sıklıkla deniz ürünlerinin tüketildiği diyettir.";
        }
    }
}

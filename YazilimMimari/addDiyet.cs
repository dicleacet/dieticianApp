using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    class addDiyet
    {
        public IDiyetler diyetOlustur(string diyet)
        {
            if (diyet == "Gluten Free Diyeti")
            {
                return new glutenFreeDiyeti();
            }
            else if (diyet == "Deniz Urunleri Diyeti")
            {
                return new denizUrunleriDiyeti();

            }
            else if (diyet == "Yesillikler Dunyasi Diyeti")
            {
                return new yesilliklerDunyasiDiyeti();
            }
            else if (diyet == "Akdeniz Diyeti")
            {
                return new akdenizDiyeti();
            }
            else
                return null;
        }
    }
}

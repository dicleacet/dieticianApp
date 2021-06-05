using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{
    public class glutenFreeDiyeti : IDiyetler
    {
        public string diyet()
        {
            return "Glutensiz diyet; buğday, çavdar, arpa ve yulaf içeren tüm gıdalardan (hububat, makarna ve birçok işlenmiş gıda) tüketmemek anlamına gelir. Mısır, patates, pirinç, soya unu zararsızdır. Et, meyveler ve sebzeler gluten içermez. Glutensiz diyet, çölyak hastalığı tedavisinin temel taşıdır.";
        }
    }
}

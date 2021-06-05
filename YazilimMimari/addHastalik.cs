using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimari
{   
    class addHastalik
    {
        private IHastaliklar colyak;
        private IHastaliklar seker;
        private IHastaliklar obez;

        public addHastalik()
        {
            obez = new obezHastasi();
            seker = new sekerHastasi();
            colyak = new çolyakHastasi();
        }

        public string getObez()
        {
            return obez.hastalik();
        }
        public string getSeker()
        {
            return seker.hastalik();
        }
        public string getColyak()
        {
            return colyak.hastalik();
        }

    }
}

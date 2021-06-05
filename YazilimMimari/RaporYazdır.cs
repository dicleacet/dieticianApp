using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SautinSoft.Document;

namespace YazilimMimari
{
    public class RaporYazdır
    {
        public string getHastalik { get; set; }
        addHastalik hastalik = new addHastalik();
        public void createHastalik()
        {
            if (Hastabilgileri.hastalik_selectedRow.Equals("Çolyak Hastasi"))
            {
                getHastalik = hastalik.getColyak();
            }
            else if (Hastabilgileri.hastalik_selectedRow.Equals("Obez Hastasi"))
            {
                getHastalik = hastalik.getObez();
            }
            else if (Hastabilgileri.hastalik_selectedRow.Equals("Seker Hastasi"))
            {
                getHastalik = hastalik.getSeker();
            }
            else
                return;
        }
        public void convertJson()
        {
            createHastalik();
            addDiyet diyet = new addDiyet();
            IDiyetler diyetler = diyet.diyetOlustur(Hastabilgileri.selectedRow);
            var kullaniciBilgi = new kullaniciBilgileri
            {
                kullaniciAd = GirisEkrani_form.NameTxt,
                kullaniciSoyad = GirisEkrani_form.SurnameTxt,
                kullaniciTc = GirisEkrani_form.TCtxt,
                diyetisyenAd = GirisEkrani_form.diyetisyenTxt,
                kullaniciHastalik = getHastalik,
                kullaniciDiyet = diyetler.diyet()
            };
            string fileName = "Rapor.json";
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(kullaniciBilgi);
            File.WriteAllText(fileName, jsonString);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimari
{
    public partial class GirisEkrani_form : Form
    {
        public GirisEkrani_form()
        {
            InitializeComponent();
        }
        public static String NameTxt = "";
        public static String SurnameTxt = "";
        public static String TCtxt = "";
        public static String diyetisyenTxt = "";
        
        private void giris_button_Click(object sender, EventArgs e)
        {
            Hastabilgileri hastabilgi = new Hastabilgileri();
            hastabilgi.Show();
            this.Hide();
        }

        private void ad_txt_TextChanged(object sender, EventArgs e)
        {
           NameTxt = ad_txt.Text;
        }

        private void Soyad_txt_TextChanged(object sender, EventArgs e)
        {
            SurnameTxt = Soyad_txt.Text;
        }

        private void Tc_txt_TextChanged(object sender, EventArgs e)
        {
            TCtxt = Tc_txt.Text;
        }

        private void diyetisyen_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            diyetisyenTxt = diyetisyen_comboBox.SelectedItem.ToString();
        }

        private void GirisEkrani_form_Load(object sender, EventArgs e)
        {
            diyetisyen_comboBox.Items.Add("Sefa Dedeoglu");
            diyetisyen_comboBox.Items.Add("Dicle Acet");
            diyetisyen_comboBox.Items.Add("Furkan Gulcan");
            diyetisyen_comboBox.Items.Add("Mert Diriker");
            diyetisyen_comboBox.Items.Add("Muhammed Kadıoglu");
            diyetisyen_comboBox.SelectedIndex = 0;
        }
    }
}

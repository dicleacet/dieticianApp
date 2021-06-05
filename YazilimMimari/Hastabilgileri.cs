using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimari
{
    public partial class Hastabilgileri : Form
    {
        public Hastabilgileri()
        {
            InitializeComponent();
            giris_button.Enabled=false;
        }
        public static String selectedRow = "";
        public static String hastalik_selectedRow = "";
        private void giris_button_Click(object sender, EventArgs e)
        {
            RaporYazdır rapor = new RaporYazdır();
            rapor.convertJson();
            Process.Start("http://127.0.0.1:5500/Rapor.html");
        }

        private void diyet_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hastalik_selectedRow.Length > 1)
            {
                giris_button.Enabled = true;
            }
            selectedRow = diyet_comboBox.SelectedItem.ToString();
        }

        private void hastalik_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedRow.Length > 1)
            {
                giris_button.Enabled = true;
            }
            hastalik_selectedRow = hastalik_comboBox.SelectedItem.ToString();
        }
    }
}

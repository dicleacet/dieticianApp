
namespace YazilimMimari
{
    partial class Hastabilgileri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hastalik_comboBox = new System.Windows.Forms.ComboBox();
            this.diyet_comboBox = new System.Windows.Forms.ComboBox();
            this.ad_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giris_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hastalik_comboBox
            // 
            this.hastalik_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hastalik_comboBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastalik_comboBox.FormattingEnabled = true;
            this.hastalik_comboBox.Items.AddRange(new object[] {
            "Çolyak Hastasi",
            "Obez Hastasi",
            "Seker Hastasi"});
            this.hastalik_comboBox.Location = new System.Drawing.Point(329, 149);
            this.hastalik_comboBox.Name = "hastalik_comboBox";
            this.hastalik_comboBox.Size = new System.Drawing.Size(160, 30);
            this.hastalik_comboBox.TabIndex = 5;
            this.hastalik_comboBox.SelectedIndexChanged += new System.EventHandler(this.hastalik_comboBox_SelectedIndexChanged);
            // 
            // diyet_comboBox
            // 
            this.diyet_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.diyet_comboBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diyet_comboBox.FormattingEnabled = true;
            this.diyet_comboBox.Items.AddRange(new object[] {
            "Gluten Free Diyeti",
            "Yesillikler Dunyasi Diyeti",
            "Akdeniz Diyeti",
            "Deniz Urunleri Diyeti"});
            this.diyet_comboBox.Location = new System.Drawing.Point(329, 208);
            this.diyet_comboBox.Name = "diyet_comboBox";
            this.diyet_comboBox.Size = new System.Drawing.Size(160, 30);
            this.diyet_comboBox.TabIndex = 6;
            this.diyet_comboBox.SelectedIndexChanged += new System.EventHandler(this.diyet_comboBox_SelectedIndexChanged);
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_label.ForeColor = System.Drawing.Color.Black;
            this.ad_label.Location = new System.Drawing.Point(161, 157);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(147, 22);
            this.ad_label.TabIndex = 9;
            this.ad_label.Text = "Hastalık Bilgisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Diyet Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "HASTA DIYET VE HASTALIK BILGISI";
            // 
            // giris_button
            // 
            this.giris_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.giris_button.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_button.Location = new System.Drawing.Point(248, 280);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(144, 60);
            this.giris_button.TabIndex = 13;
            this.giris_button.Text = "RAPOR YAZDIR";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // Hastabilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(666, 400);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ad_label);
            this.Controls.Add(this.diyet_comboBox);
            this.Controls.Add(this.hastalik_comboBox);
            this.Name = "Hastabilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hastalik_comboBox;
        private System.Windows.Forms.ComboBox diyet_comboBox;
        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button giris_button;
    }
}
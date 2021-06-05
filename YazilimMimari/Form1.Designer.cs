
namespace YazilimMimari
{
    partial class GirisEkrani_form
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
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.Tc_txt = new System.Windows.Forms.TextBox();
            this.Soyad_txt = new System.Windows.Forms.TextBox();
            this.ad_label = new System.Windows.Forms.Label();
            this.soyad_label = new System.Windows.Forms.Label();
            this.tc_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giris_button = new System.Windows.Forms.Button();
            this.diyetisyen_comboBox = new System.Windows.Forms.ComboBox();
            this.diyetisyen_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ad_txt
            // 
            this.ad_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ad_txt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_txt.Location = new System.Drawing.Point(251, 181);
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(160, 31);
            this.ad_txt.TabIndex = 1;
            this.ad_txt.TextChanged += new System.EventHandler(this.ad_txt_TextChanged);
            // 
            // Tc_txt
            // 
            this.Tc_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tc_txt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tc_txt.Location = new System.Drawing.Point(251, 276);
            this.Tc_txt.Name = "Tc_txt";
            this.Tc_txt.Size = new System.Drawing.Size(160, 31);
            this.Tc_txt.TabIndex = 3;
            this.Tc_txt.TextChanged += new System.EventHandler(this.Tc_txt_TextChanged);
            // 
            // Soyad_txt
            // 
            this.Soyad_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Soyad_txt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soyad_txt.Location = new System.Drawing.Point(251, 229);
            this.Soyad_txt.Name = "Soyad_txt";
            this.Soyad_txt.Size = new System.Drawing.Size(160, 31);
            this.Soyad_txt.TabIndex = 2;
            this.Soyad_txt.TextChanged += new System.EventHandler(this.Soyad_txt_TextChanged);
            // 
            // ad_label
            // 
            this.ad_label.AutoSize = true;
            this.ad_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_label.ForeColor = System.Drawing.Color.Black;
            this.ad_label.Location = new System.Drawing.Point(104, 190);
            this.ad_label.Name = "ad_label";
            this.ad_label.Size = new System.Drawing.Size(39, 22);
            this.ad_label.TabIndex = 8;
            this.ad_label.Text = "AD";
            // 
            // soyad_label
            // 
            this.soyad_label.AutoSize = true;
            this.soyad_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad_label.Location = new System.Drawing.Point(104, 238);
            this.soyad_label.Name = "soyad_label";
            this.soyad_label.Size = new System.Drawing.Size(79, 22);
            this.soyad_label.TabIndex = 9;
            this.soyad_label.Text = "SOYAD";
            // 
            // tc_label
            // 
            this.tc_label.AutoSize = true;
            this.tc_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_label.Location = new System.Drawing.Point(104, 285);
            this.tc_label.Name = "tc_label";
            this.tc_label.Size = new System.Drawing.Size(36, 22);
            this.tc_label.TabIndex = 10;
            this.tc_label.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "HASTA BILGILERINI GIRINIZ";
            // 
            // giris_button
            // 
            this.giris_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.giris_button.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris_button.Location = new System.Drawing.Point(191, 388);
            this.giris_button.Name = "giris_button";
            this.giris_button.Size = new System.Drawing.Size(144, 38);
            this.giris_button.TabIndex = 5;
            this.giris_button.Text = "Giris";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // diyetisyen_comboBox
            // 
            this.diyetisyen_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.diyetisyen_comboBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diyetisyen_comboBox.FormattingEnabled = true;
            this.diyetisyen_comboBox.Location = new System.Drawing.Point(251, 326);
            this.diyetisyen_comboBox.Name = "diyetisyen_comboBox";
            this.diyetisyen_comboBox.Size = new System.Drawing.Size(160, 30);
            this.diyetisyen_comboBox.TabIndex = 4;
            this.diyetisyen_comboBox.SelectedIndexChanged += new System.EventHandler(this.diyetisyen_comboBox_SelectedIndexChanged);
            // 
            // diyetisyen_label
            // 
            this.diyetisyen_label.AutoSize = true;
            this.diyetisyen_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diyetisyen_label.Location = new System.Drawing.Point(104, 334);
            this.diyetisyen_label.Name = "diyetisyen_label";
            this.diyetisyen_label.Size = new System.Drawing.Size(130, 22);
            this.diyetisyen_label.TabIndex = 14;
            this.diyetisyen_label.Text = "DIYETISYEN ";
            // 
            // GirisEkrani_form
            // 
            this.AcceptButton = this.giris_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(517, 510);
            this.Controls.Add(this.diyetisyen_label);
            this.Controls.Add(this.diyetisyen_comboBox);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tc_label);
            this.Controls.Add(this.soyad_label);
            this.Controls.Add(this.ad_label);
            this.Controls.Add(this.Soyad_txt);
            this.Controls.Add(this.Tc_txt);
            this.Controls.Add(this.ad_txt);
            this.Name = "GirisEkrani_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyetisyen Uygulaması";
            this.Load += new System.EventHandler(this.GirisEkrani_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.TextBox Tc_txt;
        private System.Windows.Forms.TextBox Soyad_txt;
        private System.Windows.Forms.Label ad_label;
        private System.Windows.Forms.Label soyad_label;
        private System.Windows.Forms.Label tc_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button giris_button;
        private System.Windows.Forms.ComboBox diyetisyen_comboBox;
        private System.Windows.Forms.Label diyetisyen_label;
    }
}


namespace ApartmanYonetim.Forms
{
    partial class FrmDaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DaireNo_txt = new System.Windows.Forms.TextBox();
            this.AdSoyad_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kat_txt = new System.Windows.Forms.TextBox();
            this.Telefon_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Durum_cmb = new System.Windows.Forms.ComboBox();
            this.Ekle_btn = new System.Windows.Forms.Button();
            this.Guncelle_btn = new System.Windows.Forms.Button();
            this.Sil_btn = new System.Windows.Forms.Button();
            this.Temizle_btn = new System.Windows.Forms.Button();
            this.Tablo_dgv = new System.Windows.Forms.DataGridView();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Resim_pb = new System.Windows.Forms.PictureBox();
            this.ResimEkle_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tablo_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı:";
            // 
            // DaireNo_txt
            // 
            this.DaireNo_txt.Location = new System.Drawing.Point(118, 22);
            this.DaireNo_txt.Name = "DaireNo_txt";
            this.DaireNo_txt.Size = new System.Drawing.Size(177, 22);
            this.DaireNo_txt.TabIndex = 2;
            this.DaireNo_txt.TextChanged += new System.EventHandler(this.DaireNo_txt_TextChanged);
            // 
            // AdSoyad_txt
            // 
            this.AdSoyad_txt.Location = new System.Drawing.Point(118, 73);
            this.AdSoyad_txt.Name = "AdSoyad_txt";
            this.AdSoyad_txt.Size = new System.Drawing.Size(177, 22);
            this.AdSoyad_txt.TabIndex = 3;
            this.AdSoyad_txt.TextChanged += new System.EventHandler(this.AdSoyad_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon:";
            // 
            // Kat_txt
            // 
            this.Kat_txt.Location = new System.Drawing.Point(118, 131);
            this.Kat_txt.Name = "Kat_txt";
            this.Kat_txt.Size = new System.Drawing.Size(177, 22);
            this.Kat_txt.TabIndex = 6;
            this.Kat_txt.TextChanged += new System.EventHandler(this.Kat_txt_TextChanged);
            // 
            // Telefon_txt
            // 
            this.Telefon_txt.Location = new System.Drawing.Point(118, 175);
            this.Telefon_txt.Name = "Telefon_txt";
            this.Telefon_txt.Size = new System.Drawing.Size(177, 22);
            this.Telefon_txt.TabIndex = 7;
            this.Telefon_txt.TextChanged += new System.EventHandler(this.Telefon_txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(385, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum:";
            // 
            // Durum_cmb
            // 
            this.Durum_cmb.FormattingEnabled = true;
            this.Durum_cmb.Items.AddRange(new object[] {
            "Ev Sahibi\t",
            "Kiracı"});
            this.Durum_cmb.Location = new System.Drawing.Point(476, 142);
            this.Durum_cmb.Name = "Durum_cmb";
            this.Durum_cmb.Size = new System.Drawing.Size(186, 24);
            this.Durum_cmb.TabIndex = 9;
            this.Durum_cmb.SelectedIndexChanged += new System.EventHandler(this.Durum_cmb_SelectedIndexChanged);
            // 
            // Ekle_btn
            // 
            this.Ekle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Ekle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Ekle_btn.FlatAppearance.BorderSize = 0;
            this.Ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekle_btn.ForeColor = System.Drawing.Color.White;
            this.Ekle_btn.Location = new System.Drawing.Point(12, 220);
            this.Ekle_btn.Name = "Ekle_btn";
            this.Ekle_btn.Size = new System.Drawing.Size(125, 44);
            this.Ekle_btn.TabIndex = 10;
            this.Ekle_btn.Text = "Ekle";
            this.Ekle_btn.UseVisualStyleBackColor = false;
            this.Ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // Guncelle_btn
            // 
            this.Guncelle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Guncelle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Guncelle_btn.FlatAppearance.BorderSize = 0;
            this.Guncelle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelle_btn.ForeColor = System.Drawing.Color.White;
            this.Guncelle_btn.Location = new System.Drawing.Point(157, 220);
            this.Guncelle_btn.Name = "Guncelle_btn";
            this.Guncelle_btn.Size = new System.Drawing.Size(125, 44);
            this.Guncelle_btn.TabIndex = 11;
            this.Guncelle_btn.Text = "Güncelle";
            this.Guncelle_btn.UseVisualStyleBackColor = false;
            this.Guncelle_btn.Click += new System.EventHandler(this.Guncelle_btn_Click);
            // 
            // Sil_btn
            // 
            this.Sil_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Sil_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Sil_btn.FlatAppearance.BorderSize = 0;
            this.Sil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_btn.ForeColor = System.Drawing.Color.White;
            this.Sil_btn.Location = new System.Drawing.Point(305, 220);
            this.Sil_btn.Name = "Sil_btn";
            this.Sil_btn.Size = new System.Drawing.Size(125, 44);
            this.Sil_btn.TabIndex = 12;
            this.Sil_btn.Text = "Sil";
            this.Sil_btn.UseVisualStyleBackColor = false;
            this.Sil_btn.Click += new System.EventHandler(this.Sil_btn_Click);
            // 
            // Temizle_btn
            // 
            this.Temizle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Temizle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Temizle_btn.FlatAppearance.BorderSize = 0;
            this.Temizle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temizle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle_btn.ForeColor = System.Drawing.Color.White;
            this.Temizle_btn.Location = new System.Drawing.Point(449, 220);
            this.Temizle_btn.Name = "Temizle_btn";
            this.Temizle_btn.Size = new System.Drawing.Size(125, 44);
            this.Temizle_btn.TabIndex = 13;
            this.Temizle_btn.Text = "Temizle";
            this.Temizle_btn.UseVisualStyleBackColor = false;
            this.Temizle_btn.Click += new System.EventHandler(this.Temizle_btn_Click);
            // 
            // Tablo_dgv
            // 
            this.Tablo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablo_dgv.Location = new System.Drawing.Point(12, 288);
            this.Tablo_dgv.Name = "Tablo_dgv";
            this.Tablo_dgv.RowHeadersWidth = 51;
            this.Tablo_dgv.RowTemplate.Height = 24;
            this.Tablo_dgv.Size = new System.Drawing.Size(685, 150);
            this.Tablo_dgv.TabIndex = 14;
            this.Tablo_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablo_dgv_CellClick);
            this.Tablo_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tablo_dgv_CellContentClick);
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(476, 175);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(186, 22);
            this.Email_txt.TabIndex = 15;
            this.Email_txt.TextChanged += new System.EventHandler(this.Email_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(387, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "E-Mail:";
            // 
            // Resim_pb
            // 
            this.Resim_pb.Location = new System.Drawing.Point(521, 22);
            this.Resim_pb.Name = "Resim_pb";
            this.Resim_pb.Size = new System.Drawing.Size(141, 110);
            this.Resim_pb.TabIndex = 17;
            this.Resim_pb.TabStop = false;
            // 
            // ResimEkle_bt
            // 
            this.ResimEkle_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.ResimEkle_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResimEkle_bt.ForeColor = System.Drawing.Color.White;
            this.ResimEkle_bt.Location = new System.Drawing.Point(431, 32);
            this.ResimEkle_bt.Name = "ResimEkle_bt";
            this.ResimEkle_bt.Size = new System.Drawing.Size(75, 43);
            this.ResimEkle_bt.TabIndex = 18;
            this.ResimEkle_bt.Text = "Resim Ekle";
            this.ResimEkle_bt.UseVisualStyleBackColor = false;
            this.ResimEkle_bt.Click += new System.EventHandler(this.ResimEkle_bt_Click);
            // 
            // FrmDaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.ResimEkle_bt);
            this.Controls.Add(this.Resim_pb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.Tablo_dgv);
            this.Controls.Add(this.Temizle_btn);
            this.Controls.Add(this.Sil_btn);
            this.Controls.Add(this.Guncelle_btn);
            this.Controls.Add(this.Ekle_btn);
            this.Controls.Add(this.Durum_cmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Telefon_txt);
            this.Controls.Add(this.Kat_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdSoyad_txt);
            this.Controls.Add(this.DaireNo_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDaire";
            this.Text = "FrmDaire";
            this.Load += new System.EventHandler(this.FrmDaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablo_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DaireNo_txt;
        private System.Windows.Forms.TextBox AdSoyad_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Kat_txt;
        private System.Windows.Forms.TextBox Telefon_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Durum_cmb;
        private System.Windows.Forms.Button Ekle_btn;
        private System.Windows.Forms.Button Guncelle_btn;
        private System.Windows.Forms.Button Sil_btn;
        private System.Windows.Forms.Button Temizle_btn;
        private System.Windows.Forms.DataGridView Tablo_dgv;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Resim_pb;
        private System.Windows.Forms.Button ResimEkle_bt;
    }
}
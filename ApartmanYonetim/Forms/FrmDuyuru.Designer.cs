namespace ApartmanYonetim.Forms
{
    partial class FrmDuyuru
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
            this.lblBaslikAlani = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblListe = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.dgvDuyurular = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslikAlani
            // 
            this.lblBaslikAlani.AutoSize = true;
            this.lblBaslikAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikAlani.Location = new System.Drawing.Point(13, 9);
            this.lblBaslikAlani.Name = "lblBaslikAlani";
            this.lblBaslikAlani.Size = new System.Drawing.Size(95, 18);
            this.lblBaslikAlani.TabIndex = 0;
            this.lblBaslikAlani.Text = "Başlık Alanı";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcerik.Location = new System.Drawing.Point(13, 77);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(49, 18);
            this.lblIcerik.TabIndex = 1;
            this.lblIcerik.Text = "İçerik";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(13, 227);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(46, 18);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih";
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListe.Location = new System.Drawing.Point(78, 273);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(44, 18);
            this.lblListe.TabIndex = 3;
            this.lblListe.Text = "Liste";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(16, 30);
            this.txtBaslik.Multiline = true;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(666, 44);
            this.txtBaslik.TabIndex = 4;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(16, 98);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(666, 118);
            this.txtIcerik.TabIndex = 5;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(16, 248);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 6;
            // 
            // dgvDuyurular
            // 
            this.dgvDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyurular.Location = new System.Drawing.Point(62, 294);
            this.dgvDuyurular.Name = "dgvDuyurular";
            this.dgvDuyurular.RowHeadersWidth = 51;
            this.dgvDuyurular.RowTemplate.Height = 24;
            this.dgvDuyurular.Size = new System.Drawing.Size(573, 150);
            this.dgvDuyurular.TabIndex = 7;
            this.dgvDuyurular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuyurular_CellClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(243, 246);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 30);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(401, 246);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 30);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(558, 246);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(124, 30);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // FrmDuyuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 457);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvDuyurular);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblBaslikAlani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDuyuru";
            this.Text = "FrmDuyuru";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslikAlani;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DataGridView dgvDuyurular;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
    }
}
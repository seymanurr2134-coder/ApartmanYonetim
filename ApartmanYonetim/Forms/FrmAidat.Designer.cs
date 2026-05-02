namespace ApartmanYonetim.Forms
{
    partial class FrmAidat
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
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSonOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnAidatOlustur = new System.Windows.Forms.Button();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dgvAidatlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidatlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(423, 45);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(195, 22);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTutar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yıl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(251, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Son Ödeme Tarihi:";
            // 
            // dtpSonOdemeTarihi
            // 
            this.dtpSonOdemeTarihi.Location = new System.Drawing.Point(423, 117);
            this.dtpSonOdemeTarihi.Name = "dtpSonOdemeTarihi";
            this.dtpSonOdemeTarihi.Size = new System.Drawing.Size(195, 22);
            this.dtpSonOdemeTarihi.TabIndex = 7;
            this.dtpSonOdemeTarihi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSonOdemeTarihi_KeyDown);
            // 
            // btnAidatOlustur
            // 
            this.btnAidatOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnAidatOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAidatOlustur.ForeColor = System.Drawing.Color.White;
            this.btnAidatOlustur.Location = new System.Drawing.Point(27, 185);
            this.btnAidatOlustur.Name = "btnAidatOlustur";
            this.btnAidatOlustur.Size = new System.Drawing.Size(216, 47);
            this.btnAidatOlustur.TabIndex = 8;
            this.btnAidatOlustur.Text = "Aidat Oluştur";
            this.btnAidatOlustur.UseVisualStyleBackColor = false;
            this.btnAidatOlustur.Click += new System.EventHandler(this.btnAidatOlustur_Click_1);
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(65, 39);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(121, 24);
            this.cmbAy.TabIndex = 10;
            // 
            // cmbYil
            // 
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(65, 117);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(121, 24);
            this.cmbYil.TabIndex = 11;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(360, 185);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(216, 47);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgvAidatlar
            // 
            this.dgvAidatlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAidatlar.Location = new System.Drawing.Point(12, 275);
            this.dgvAidatlar.Name = "dgvAidatlar";
            this.dgvAidatlar.RowHeadersWidth = 51;
            this.dgvAidatlar.RowTemplate.Height = 24;
            this.dgvAidatlar.Size = new System.Drawing.Size(677, 150);
            this.dgvAidatlar.TabIndex = 13;
            this.dgvAidatlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAidatlar_CellContentClick);
            // 
            // FrmAidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAidatlar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.btnAidatOlustur);
            this.Controls.Add(this.dtpSonOdemeTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAidat";
            this.Text = "Aidat";
            this.Load += new System.EventHandler(this.FrmAidat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAidatlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSonOdemeTarihi;
        private System.Windows.Forms.Button btnAidatOlustur;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgvAidatlar;
    }
}
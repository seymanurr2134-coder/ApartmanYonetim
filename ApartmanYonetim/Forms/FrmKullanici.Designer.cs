namespace ApartmanYonetim.Forms
{
    partial class FrmKullanici
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
            this.ustPanel = new System.Windows.Forms.Panel();
            this.solMenuPanel = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnGecmisOdemeler = new System.Windows.Forms.Button();
            this.btnBorclar = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.icerikPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.solMenuPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.ustPanel.Location = new System.Drawing.Point(199, 1);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(745, 66);
            this.ustPanel.TabIndex = 0;
            // 
            // solMenuPanel
            // 
            this.solMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.solMenuPanel.Controls.Add(this.btnCikis);
            this.solMenuPanel.Controls.Add(this.btnDuyurular);
            this.solMenuPanel.Controls.Add(this.btnProfil);
            this.solMenuPanel.Controls.Add(this.btnGecmisOdemeler);
            this.solMenuPanel.Controls.Add(this.btnBorclar);
            this.solMenuPanel.Controls.Add(this.btnAnaSayfa);
            this.solMenuPanel.Location = new System.Drawing.Point(2, 67);
            this.solMenuPanel.Name = "solMenuPanel";
            this.solMenuPanel.Size = new System.Drawing.Size(200, 498);
            this.solMenuPanel.TabIndex = 1;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(3, 450);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(194, 45);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnDuyurular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyurular.ForeColor = System.Drawing.Color.White;
            this.btnDuyurular.Location = new System.Drawing.Point(3, 156);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(194, 45);
            this.btnDuyurular.TabIndex = 4;
            this.btnDuyurular.Text = "📢 Duyurular";
            this.btnDuyurular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuyurular.UseVisualStyleBackColor = false;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Location = new System.Drawing.Point(3, 207);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(194, 45);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "👤 Profilim";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnGecmisOdemeler
            // 
            this.btnGecmisOdemeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnGecmisOdemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisOdemeler.ForeColor = System.Drawing.Color.White;
            this.btnGecmisOdemeler.Location = new System.Drawing.Point(3, 105);
            this.btnGecmisOdemeler.Name = "btnGecmisOdemeler";
            this.btnGecmisOdemeler.Size = new System.Drawing.Size(194, 45);
            this.btnGecmisOdemeler.TabIndex = 2;
            this.btnGecmisOdemeler.Text = "💳 Geçmiş Ödemeler";
            this.btnGecmisOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGecmisOdemeler.UseVisualStyleBackColor = false;
            this.btnGecmisOdemeler.Click += new System.EventHandler(this.btnGecmisOdemeler_Click);
            // 
            // btnBorclar
            // 
            this.btnBorclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnBorclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorclar.ForeColor = System.Drawing.Color.White;
            this.btnBorclar.Location = new System.Drawing.Point(3, 54);
            this.btnBorclar.Name = "btnBorclar";
            this.btnBorclar.Size = new System.Drawing.Size(194, 45);
            this.btnBorclar.TabIndex = 1;
            this.btnBorclar.Text = "💰 Borçlarım";
            this.btnBorclar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorclar.UseVisualStyleBackColor = false;
            this.btnBorclar.Click += new System.EventHandler(this.btnBorclar_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnAnaSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfa.Location = new System.Drawing.Point(3, 3);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(194, 45);
            this.btnAnaSayfa.TabIndex = 0;
            this.btnAnaSayfa.Text = "🏠︎ Ana Sayfa";
            this.btnAnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click_1);
            // 
            // icerikPanel
            // 
            this.icerikPanel.Location = new System.Drawing.Point(208, 73);
            this.icerikPanel.Name = "icerikPanel";
            this.icerikPanel.Size = new System.Drawing.Size(736, 492);
            this.icerikPanel.TabIndex = 2;
            this.icerikPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.icerikPanel_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 66);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apartman Yönetim Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.icerikPanel);
            this.Controls.Add(this.solMenuPanel);
            this.Controls.Add(this.ustPanel);
            this.Name = "FrmKullanici";
            this.Text = "FrmKullanici";
            this.Load += new System.EventHandler(this.FrmKullanici_Load);
            this.solMenuPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Panel solMenuPanel;
        private System.Windows.Forms.Panel icerikPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnGecmisOdemeler;
        private System.Windows.Forms.Button btnBorclar;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label label1;
    }
}
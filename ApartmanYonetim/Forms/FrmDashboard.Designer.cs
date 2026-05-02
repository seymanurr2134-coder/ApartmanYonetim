namespace ApartmanYonetim.Forms
{
    partial class FrmDashboard
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.btnBorc = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnAidat = new System.Windows.Forms.Button();
            this.btnDaire = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.btnCikis);
            this.panelMenu.Controls.Add(this.btnDuyuru);
            this.panelMenu.Controls.Add(this.btnBorc);
            this.panelMenu.Controls.Add(this.btnRapor);
            this.panelMenu.Controls.Add(this.btnAidat);
            this.panelMenu.Controls.Add(this.btnDaire);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 577);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(0, 528);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(236, 46);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyuru.ForeColor = System.Drawing.Color.White;
            this.btnDuyuru.Location = new System.Drawing.Point(0, 276);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(236, 46);
            this.btnDuyuru.TabIndex = 4;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // btnBorc
            // 
            this.btnBorc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorc.ForeColor = System.Drawing.Color.White;
            this.btnBorc.Location = new System.Drawing.Point(0, 194);
            this.btnBorc.Name = "btnBorc";
            this.btnBorc.Size = new System.Drawing.Size(236, 46);
            this.btnBorc.TabIndex = 3;
            this.btnBorc.Text = "Borç Sorgula";
            this.btnBorc.UseVisualStyleBackColor = true;
            this.btnBorc.Click += new System.EventHandler(this.btnBorc_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.White;
            this.btnRapor.Location = new System.Drawing.Point(0, 233);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(236, 46);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnAidat
            // 
            this.btnAidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAidat.ForeColor = System.Drawing.Color.White;
            this.btnAidat.Location = new System.Drawing.Point(0, 151);
            this.btnAidat.Name = "btnAidat";
            this.btnAidat.Size = new System.Drawing.Size(236, 46);
            this.btnAidat.TabIndex = 1;
            this.btnAidat.Text = "Aidat Tanımla";
            this.btnAidat.UseVisualStyleBackColor = true;
            this.btnAidat.Click += new System.EventHandler(this.btnAidat_Click);
            // 
            // btnDaire
            // 
            this.btnDaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDaire.ForeColor = System.Drawing.Color.White;
            this.btnDaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaire.Location = new System.Drawing.Point(0, 108);
            this.btnDaire.Name = "btnDaire";
            this.btnDaire.Size = new System.Drawing.Size(236, 46);
            this.btnDaire.TabIndex = 0;
            this.btnDaire.Text = "Daire İşlemleri";
            this.btnDaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDaire.UseVisualStyleBackColor = true;
            this.btnDaire.Click += new System.EventHandler(this.btnDaire_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panelTop.Controls.Add(this.lblBaslik);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(949, 111);
            this.panelTop.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(322, 34);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(316, 32);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YÖNETİCİ ANA MENÜ";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Location = new System.Drawing.Point(242, 117);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(694, 457);
            this.panelContent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apartman Yönetim Paneline Hoş Geldiniz!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoş Geldiniz!";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 577);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnDaire;
        private System.Windows.Forms.Button btnBorc;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnAidat;
        private System.Windows.Forms.Button btnDuyuru;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
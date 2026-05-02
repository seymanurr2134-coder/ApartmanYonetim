namespace ApartmanYonetim.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.EMail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_GirisYap = new System.Windows.Forms.Button();
            this.sifremiunuttum_link = new System.Windows.Forms.PictureBox();
            this.lnk_sifremiunuttum = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifremiunuttum_link)).BeginInit();
            this.SuspendLayout();
            // 
            // EMail
            // 
            this.EMail.Location = new System.Drawing.Point(186, 123);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(271, 22);
            this.EMail.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 73);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "APARTMAN YÖNETİM SİSTEMİ";
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(186, 202);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(271, 22);
            this.Sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(183, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // Btn_GirisYap
            // 
            this.Btn_GirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.Btn_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_GirisYap.ForeColor = System.Drawing.Color.White;
            this.Btn_GirisYap.Location = new System.Drawing.Point(257, 275);
            this.Btn_GirisYap.Name = "Btn_GirisYap";
            this.Btn_GirisYap.Size = new System.Drawing.Size(116, 41);
            this.Btn_GirisYap.TabIndex = 5;
            this.Btn_GirisYap.Text = "GİRİŞ YAP";
            this.Btn_GirisYap.UseVisualStyleBackColor = false;
            this.Btn_GirisYap.Click += new System.EventHandler(this.Btn_GirisYap_Click);
            // 
            // sifremiunuttum_link
            // 
            this.sifremiunuttum_link.BackColor = System.Drawing.SystemColors.Control;
            this.sifremiunuttum_link.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sifremiunuttum_link.Image = ((System.Drawing.Image)(resources.GetObject("sifremiunuttum_link.Image")));
            this.sifremiunuttum_link.Location = new System.Drawing.Point(0, 0);
            this.sifremiunuttum_link.Name = "sifremiunuttum_link";
            this.sifremiunuttum_link.Size = new System.Drawing.Size(648, 483);
            this.sifremiunuttum_link.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifremiunuttum_link.TabIndex = 6;
            this.sifremiunuttum_link.TabStop = false;
            // 
            // lnk_sifremiunuttum
            // 
            this.lnk_sifremiunuttum.Location = new System.Drawing.Point(257, 434);
            this.lnk_sifremiunuttum.Name = "lnk_sifremiunuttum";
            this.lnk_sifremiunuttum.Size = new System.Drawing.Size(111, 23);
            this.lnk_sifremiunuttum.TabIndex = 7;
            this.lnk_sifremiunuttum.TabStop = true;
            this.lnk_sifremiunuttum.Text = "Şifremi Unuttum !";
            this.lnk_sifremiunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_sifremiunuttum_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 483);
            this.Controls.Add(this.lnk_sifremiunuttum);
            this.Controls.Add(this.Btn_GirisYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EMail);
            this.Controls.Add(this.sifremiunuttum_link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Apartman Yönetim Sistemi";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifremiunuttum_link)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EMail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_GirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox sifremiunuttum_link;
        private System.Windows.Forms.LinkLabel lnk_sifremiunuttum;
    }
}
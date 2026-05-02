namespace ApartmanYonetim.Forms
{
    partial class frmKullaniciAnasayfa
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.lblBorc = new System.Windows.Forms.Label();
            this.dataGridViewOdemeler = new System.Windows.Forms.DataGridView();
            this.colAy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDuyuru = new System.Windows.Forms.Panel();
            this.lblDuyuru = new System.Windows.Forms.Label();
            this.lblDaireBilgi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlDuyuru.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.Location = new System.Drawing.Point(13, 13);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(164, 29);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoşgeldiniz,";
            this.lblHosgeldin.Click += new System.EventHandler(this.lblHosgeldin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 42);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "💰 Güncel Borcunuz";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnOdemeYap);
            this.panel2.Controls.Add(this.lblBorc);
            this.panel2.Location = new System.Drawing.Point(6, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 54);
            this.panel2.TabIndex = 2;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(519, 12);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(148, 36);
            this.btnOdemeYap.TabIndex = 1;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorc.Location = new System.Drawing.Point(36, 19);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(151, 20);
            this.lblBorc.TabIndex = 0;
            this.lblBorc.Text = "Toplam Borcunuz: ";
            // 
            // dataGridViewOdemeler
            // 
            this.dataGridViewOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdemeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAy,
            this.colYil,
            this.colTutar,
            this.colDurum});
            this.dataGridViewOdemeler.Location = new System.Drawing.Point(9, 193);
            this.dataGridViewOdemeler.Name = "dataGridViewOdemeler";
            this.dataGridViewOdemeler.RowHeadersWidth = 51;
            this.dataGridViewOdemeler.RowTemplate.Height = 24;
            this.dataGridViewOdemeler.Size = new System.Drawing.Size(647, 145);
            this.dataGridViewOdemeler.TabIndex = 3;
            // 
            // colAy
            // 
            this.colAy.HeaderText = "Ay";
            this.colAy.MinimumWidth = 6;
            this.colAy.Name = "colAy";
            this.colAy.Width = 125;
            // 
            // colYil
            // 
            this.colYil.HeaderText = "Yıl";
            this.colYil.MinimumWidth = 6;
            this.colYil.Name = "colYil";
            this.colYil.Width = 125;
            // 
            // colTutar
            // 
            this.colTutar.HeaderText = "Tutar";
            this.colTutar.MinimumWidth = 6;
            this.colTutar.Name = "colTutar";
            this.colTutar.Width = 125;
            // 
            // colDurum
            // 
            this.colDurum.HeaderText = "Durum";
            this.colDurum.MinimumWidth = 6;
            this.colDurum.Name = "colDurum";
            this.colDurum.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(9, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 28);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Son Ödemeler";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(547, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(177, 122);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "adminuser@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "0555 555 55 55";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Bilgileri";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(6, 347);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 34);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(472, 47);
            this.panel6.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "📢 Duyurular";
            // 
            // pnlDuyuru
            // 
            this.pnlDuyuru.Controls.Add(this.lblDuyuru);
            this.pnlDuyuru.Location = new System.Drawing.Point(9, 384);
            this.pnlDuyuru.Name = "pnlDuyuru";
            this.pnlDuyuru.Size = new System.Drawing.Size(496, 84);
            this.pnlDuyuru.TabIndex = 8;
            // 
            // lblDuyuru
            // 
            this.lblDuyuru.BackColor = System.Drawing.Color.White;
            this.lblDuyuru.Location = new System.Drawing.Point(-3, 0);
            this.lblDuyuru.Name = "lblDuyuru";
            this.lblDuyuru.Size = new System.Drawing.Size(499, 82);
            this.lblDuyuru.TabIndex = 0;
            // 
            // lblDaireBilgi
            // 
            this.lblDaireBilgi.Location = new System.Drawing.Point(18, 43);
            this.lblDaireBilgi.Name = "lblDaireBilgi";
            this.lblDaireBilgi.Size = new System.Drawing.Size(135, 19);
            this.lblDaireBilgi.TabIndex = 9;
            // 
            // frmKullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 492);
            this.Controls.Add(this.lblDaireBilgi);
            this.Controls.Add(this.pnlDuyuru);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewOdemeler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHosgeldin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullaniciAnasayfa";
            this.Text = "frmKullaniciAnasayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlDuyuru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewOdemeler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlDuyuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDurum;
        private System.Windows.Forms.Label lblDuyuru;
        private System.Windows.Forms.Label lblDaireBilgi;
    }
}
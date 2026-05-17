namespace ApartmanYonetim.Forms
{
    partial class FrmBorc
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
            this.cmbDaire = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.dgvBorclar = new System.Windows.Forms.DataGridView();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDaire
            // 
            this.cmbDaire.FormattingEnabled = true;
            this.cmbDaire.Location = new System.Drawing.Point(130, 41);
            this.cmbDaire.Name = "cmbDaire";
            this.cmbDaire.Size = new System.Drawing.Size(194, 24);
            this.cmbDaire.TabIndex = 0;
            this.cmbDaire.SelectedIndexChanged += new System.EventHandler(this.cmbDaire_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daire Seç:";
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Location = new System.Drawing.Point(25, 98);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(91, 16);
            this.lblToplamBorc.TabIndex = 2;
            this.lblToplamBorc.Text = "Toplam Borç: ";
            // 
            // dgvBorclar
            // 
            this.dgvBorclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorclar.Location = new System.Drawing.Point(28, 192);
            this.dgvBorclar.Name = "dgvBorclar";
            this.dgvBorclar.RowHeadersWidth = 51;
            this.dgvBorclar.RowTemplate.Height = 24;
            this.dgvBorclar.Size = new System.Drawing.Size(641, 150);
            this.dgvBorclar.TabIndex = 3;
            this.dgvBorclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorclar_CellClick);
            this.dgvBorclar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBorclar_CellFormatting);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(28, 370);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(195, 48);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "Tahsilat Gir";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // FrmBorc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 457);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.dgvBorclar);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBorc";
            this.Text = "FrmBorc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.DataGridView dgvBorclar;
        private System.Windows.Forms.Button btnOdemeYap;
    }
}
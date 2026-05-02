namespace ApartmanYonetim.Forms
{
    partial class frmBorclarim
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
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.dgvBorclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BORÇLARIM";
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.Location = new System.Drawing.Point(46, 399);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(231, 29);
            this.lblToplamBorc.TabIndex = 3;
            this.lblToplamBorc.Text = "Toplam Borcunuz: ";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeYap.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYap.Location = new System.Drawing.Point(432, 398);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(168, 38);
            this.btnOdemeYap.TabIndex = 4;
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // dgvBorclar
            // 
            this.dgvBorclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorclar.Location = new System.Drawing.Point(42, 128);
            this.dgvBorclar.Name = "dgvBorclar";
            this.dgvBorclar.RowHeadersWidth = 51;
            this.dgvBorclar.RowTemplate.Height = 24;
            this.dgvBorclar.Size = new System.Drawing.Size(654, 188);
            this.dgvBorclar.TabIndex = 5;
            this.dgvBorclar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBorclar_CellFormatting);
            // 
            // frmBorclarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 492);
            this.Controls.Add(this.dgvBorclar);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBorclarim";
            this.Text = "frmBorclarim";
            this.Load += new System.EventHandler(this.frmBorclarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.DataGridView dgvBorclar;
    }
}
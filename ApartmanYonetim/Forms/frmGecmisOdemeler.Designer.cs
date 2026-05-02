namespace ApartmanYonetim.Forms
{
    partial class frmGecmisOdemeler
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
            this.dgvGecmisOdemeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GEÇMİŞ ÖDEMELER";
            // 
            // dgvGecmisOdemeler
            // 
            this.dgvGecmisOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisOdemeler.Location = new System.Drawing.Point(55, 96);
            this.dgvGecmisOdemeler.Name = "dgvGecmisOdemeler";
            this.dgvGecmisOdemeler.ReadOnly = true;
            this.dgvGecmisOdemeler.RowHeadersWidth = 51;
            this.dgvGecmisOdemeler.RowTemplate.Height = 24;
            this.dgvGecmisOdemeler.Size = new System.Drawing.Size(593, 239);
            this.dgvGecmisOdemeler.TabIndex = 1;
            this.dgvGecmisOdemeler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBorclar_CellFormatting);
            // 
            // frmGecmisOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 445);
            this.Controls.Add(this.dgvGecmisOdemeler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGecmisOdemeler";
            this.Text = "frmGecmisOdemeler";
            this.Load += new System.EventHandler(this.frmGecmisOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGecmisOdemeler;
    }
}
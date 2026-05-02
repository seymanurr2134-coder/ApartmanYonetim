namespace ApartmanYonetim.Forms
{
    partial class frmDuyurular
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
            this.dgvDuyurular = new System.Windows.Forms.DataGridView();
            this.lblDuyuru = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDuyurular
            // 
            this.dgvDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyurular.Location = new System.Drawing.Point(12, 99);
            this.dgvDuyurular.Name = "dgvDuyurular";
            this.dgvDuyurular.RowHeadersWidth = 51;
            this.dgvDuyurular.RowTemplate.Height = 24;
            this.dgvDuyurular.Size = new System.Drawing.Size(694, 320);
            this.dgvDuyurular.TabIndex = 0;
            this.dgvDuyurular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuyurular_CellContentClick);
            // 
            // lblDuyuru
            // 
            this.lblDuyuru.AutoSize = true;
            this.lblDuyuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuyuru.Location = new System.Drawing.Point(12, 20);
            this.lblDuyuru.Name = "lblDuyuru";
            this.lblDuyuru.Size = new System.Drawing.Size(154, 36);
            this.lblDuyuru.TabIndex = 1;
            this.lblDuyuru.Text = "Duyurular";
            // 
            // frmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 445);
            this.Controls.Add(this.lblDuyuru);
            this.Controls.Add(this.dgvDuyurular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDuyurular";
            this.Text = "frmDuyurular";
            this.Load += new System.EventHandler(this.frmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDuyurular;
        private System.Windows.Forms.Label lblDuyuru;
    }
}
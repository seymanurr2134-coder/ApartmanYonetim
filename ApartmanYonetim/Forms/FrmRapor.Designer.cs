namespace ApartmanYonetim.Forms
{
    partial class FrmRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.lblOdenmeyenDaire = new System.Windows.Forms.Label();
            this.lblToplamGelirDeger = new System.Windows.Forms.Label();
            this.lblOdenmeyenDaireDeger = new System.Windows.Forms.Label();
            this.lblGecikenBorc = new System.Windows.Forms.Label();
            this.lblGecikenBorcDeger = new System.Windows.Forms.Label();
            this.chartGelir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartGelir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelir.Location = new System.Drawing.Point(22, 39);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(123, 20);
            this.lblToplamGelir.TabIndex = 0;
            this.lblToplamGelir.Text = "Toplam Gelir:";
            // 
            // lblOdenmeyenDaire
            // 
            this.lblOdenmeyenDaire.AutoSize = true;
            this.lblOdenmeyenDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenmeyenDaire.Location = new System.Drawing.Point(22, 90);
            this.lblOdenmeyenDaire.Name = "lblOdenmeyenDaire";
            this.lblOdenmeyenDaire.Size = new System.Drawing.Size(165, 20);
            this.lblOdenmeyenDaire.TabIndex = 1;
            this.lblOdenmeyenDaire.Text = "Ödenmeyen Daire:";
            // 
            // lblToplamGelirDeger
            // 
            this.lblToplamGelirDeger.AutoSize = true;
            this.lblToplamGelirDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGelirDeger.Location = new System.Drawing.Point(151, 41);
            this.lblToplamGelirDeger.Name = "lblToplamGelirDeger";
            this.lblToplamGelirDeger.Size = new System.Drawing.Size(37, 18);
            this.lblToplamGelirDeger.TabIndex = 2;
            this.lblToplamGelirDeger.Text = "0 TL";
            // 
            // lblOdenmeyenDaireDeger
            // 
            this.lblOdenmeyenDaireDeger.AutoSize = true;
            this.lblOdenmeyenDaireDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenmeyenDaireDeger.Location = new System.Drawing.Point(193, 92);
            this.lblOdenmeyenDaireDeger.Name = "lblOdenmeyenDaireDeger";
            this.lblOdenmeyenDaireDeger.Size = new System.Drawing.Size(16, 18);
            this.lblOdenmeyenDaireDeger.TabIndex = 3;
            this.lblOdenmeyenDaireDeger.Text = "0";
            // 
            // lblGecikenBorc
            // 
            this.lblGecikenBorc.AutoSize = true;
            this.lblGecikenBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecikenBorc.Location = new System.Drawing.Point(22, 139);
            this.lblGecikenBorc.Name = "lblGecikenBorc";
            this.lblGecikenBorc.Size = new System.Drawing.Size(129, 20);
            this.lblGecikenBorc.TabIndex = 4;
            this.lblGecikenBorc.Text = "Geçiken Borç:";
            // 
            // lblGecikenBorcDeger
            // 
            this.lblGecikenBorcDeger.AutoSize = true;
            this.lblGecikenBorcDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecikenBorcDeger.Location = new System.Drawing.Point(157, 141);
            this.lblGecikenBorcDeger.Name = "lblGecikenBorcDeger";
            this.lblGecikenBorcDeger.Size = new System.Drawing.Size(16, 18);
            this.lblGecikenBorcDeger.TabIndex = 5;
            this.lblGecikenBorcDeger.Text = "0";
            // 
            // chartGelir
            // 
            chartArea4.Name = "ChartArea1";
            this.chartGelir.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartGelir.Legends.Add(legend4);
            this.chartGelir.Location = new System.Drawing.Point(239, 30);
            this.chartGelir.Name = "chartGelir";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartGelir.Series.Add(series4);
            this.chartGelir.Size = new System.Drawing.Size(429, 320);
            this.chartGelir.TabIndex = 6;
            this.chartGelir.Text = "chart1";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(26, 249);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(147, 39);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 457);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.chartGelir);
            this.Controls.Add(this.lblGecikenBorcDeger);
            this.Controls.Add(this.lblGecikenBorc);
            this.Controls.Add(this.lblOdenmeyenDaireDeger);
            this.Controls.Add(this.lblToplamGelirDeger);
            this.Controls.Add(this.lblOdenmeyenDaire);
            this.Controls.Add(this.lblToplamGelir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            ((System.ComponentModel.ISupportInitialize)(this.chartGelir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label lblOdenmeyenDaire;
        private System.Windows.Forms.Label lblToplamGelirDeger;
        private System.Windows.Forms.Label lblOdenmeyenDaireDeger;
        private System.Windows.Forms.Label lblGecikenBorc;
        private System.Windows.Forms.Label lblGecikenBorcDeger;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGelir;
        private System.Windows.Forms.Button btnYenile;
    }
}
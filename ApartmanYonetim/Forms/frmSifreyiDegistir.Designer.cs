namespace ApartmanYonetim.Forms
{
    partial class frmSifreyiDegistir
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
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(126, 69);
            this.txtEskiSifre.Multiline = true;
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.PasswordChar = '*';
            this.txtEskiSifre.Size = new System.Drawing.Size(300, 37);
            this.txtEskiSifre.TabIndex = 0;
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(126, 268);
            this.txtYeniSifreTekrar.Multiline = true;
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.PasswordChar = '*';
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(300, 36);
            this.txtYeniSifreTekrar.TabIndex = 1;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(126, 162);
            this.txtYeniSifre.Multiline = true;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(300, 37);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.BackColor = System.Drawing.Color.Brown;
            this.btnSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegistir.ForeColor = System.Drawing.Color.White;
            this.btnSifreDegistir.Location = new System.Drawing.Point(142, 356);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(247, 46);
            this.btnSifreDegistir.TabIndex = 3;
            this.btnSifreDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = false;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(126, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre Tekrar:";
            // 
            // frmSifreyiDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtEskiSifre);
            this.Name = "frmSifreyiDegistir";
            this.Text = "frmSifreyiDegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
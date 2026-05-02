namespace ApartmanYonetim.Forms
{
    partial class FrmSifremiUnuttum
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
            this.email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(39, 62);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 20);
            this.email.TabIndex = 0;
            this.email.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(34, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(64, 162);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(162, 34);
            this.btnGonder.TabIndex = 2;
            this.btnGonder.Text = "Yeni Şifre Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // FrmSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 274);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Name = "FrmSifremiUnuttum";
            this.Text = "FrmSifremiUnuttum";
            this.Load += new System.EventHandler(this.FrmSifremiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGonder;
    }
}
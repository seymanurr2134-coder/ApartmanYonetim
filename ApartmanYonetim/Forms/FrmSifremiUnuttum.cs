using ApartmanYonetim.DAL;
using ApartmanYonetim.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYonetim.Forms
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
       

        // Mail Gönderme Fonksiyonu
        private bool MailGonder(string aliciEmail, string sifre)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("proje_mail_adresiniz@gmail.com");
                    mail.To.Add(aliciEmail);
                    mail.Subject = "Apartman Yönetimi - Geçici Şifre";
                    mail.Body = $"Sisteme giriş için geçici şifreniz: {sifre}\n Giriş yaptıktan sonra şifrenizi değiştirmeniz önerilir.";

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("proje_mail_adresiniz@gmail.com", "uygulama_ozel_sifresi");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                return true;
            }
            catch { return false; }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            KullaniciDAL dal = new KullaniciDAL();

            // 1. Email kontrolü yapıyoruz
            if (dal.EmailKontrol(email))
            {
                // 2. Senin projendeki PasswordGenerator'ı kullanarak şifre üretelim
                // Eğer PasswordGenerator bu formda erişilemezse Guid.NewGuid().ToString().Substring(0, 8) kullanabilirsin
                string yeniGeciciSifre = PasswordGenerator.SifreUret();

                // 3. Veritabanını yeni geçici şifre ile güncelleyelim
                if (dal.GeciciSifreGuncelle(email, yeniGeciciSifre))
                {
                    try
                    {
                        // 4. Zaten çalışan MailHelper sınıfını kullanıyoruz
                        MailHelper.MailGonder(email, yeniGeciciSifre);

                        MessageBox.Show("Yeni geçici şifreniz başarıyla gönderildi. Giriş yaptıktan sonra şifrenizi değiştirmeyi unutmayın.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı güncellendi ancak mail gönderilirken bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu e-posta adresi sistemde kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

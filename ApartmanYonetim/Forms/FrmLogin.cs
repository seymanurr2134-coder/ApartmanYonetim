using ApartmanYonetim.DAL;
using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApartmanYonetim.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Load += FrmLogin_Load;

        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            sifremiunuttum_link.Image = SetImageOpacity(sifremiunuttum_link.Image, 0.1f);

            Image img = Image.FromFile("C:\\Users\\ASUS\\OneDrive\\Desktop\\1.jpg"); // kendi yolunu yaz
            sifremiunuttum_link.Image = SetImageOpacity(img, 0.2f);

        }
        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }



        private void Btn_GirisYap_Click(object sender, EventArgs e)
        {

            /*
            KullaniciDAL dal = new KullaniciDAL();
            Kullanici kullanici = dal.Login(KullaniciAdi.Text, Sifre.Text);

            if (kullanici != null)
            {
                if (kullanici.Rol == "Yonetici")
                {
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    FrmKullanici frm = new FrmKullanici();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
            */
            /* *******************************************
            KullaniciDAL dal = new KullaniciDAL();

            var kullanici = dal.Login(KullaniciAdi.Text, Sifre.Text);

            if (kullanici != null)
            {
                MessageBox.Show("Giriş başarılı");

                if (kullanici.Rol == "Yonetici")
                {
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show();
                }
                else
                {
                    FrmKullanici frm = new FrmKullanici();
                    frm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
            ********************************************************** */

            KullaniciDAL dal = new KullaniciDAL();
            


            // EMail ve Sifre textbox'larından veriyi alıyoruz
            var kullanici = dal.Login(EMail.Text, Sifre.Text);

            if (kullanici != null ) // Giriş başarılıysa bu blok çalışır
            {
                MessageBox.Show("Giriş başarılı");

                // Global değişkenleri dolduruyoruz
                Program.AktifKullaniciAdSoyad = kullanici.KullaniciAdi;
                Program.AktifKullaniciId = kullanici.Id;
                Program.AktifDaireId = kullanici.Id;
                Program.AktifKullaniciEmail = kullanici.Email;

                // EĞER ŞİFRE SIFIRLANDI MI KONTROLÜ YAPMAK İSTERSEN:
                // (Veritabanına 'SifreSifirlandiMi' sütunu eklediysen burayı kullanabilirsin)
                /*
                if (kullanici.SifreSifirlandiMi)
                {
                    MessageBox.Show("Güvenliğiniz için lütfen şifrenizi güncelleyin.");
                    frmSifreyiDegistir frmSifre = new frmSifreyiDegistir();
                    frmSifre.ShowDialog(); 
                }
                */

                // Rol kontrolüne göre yönlendirme yapıyoruz
                if (kullanici.Rol == "Yonetici")
                {
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show();
                }
                else
                {
                    FrmKullanici frm = new FrmKullanici();
                    frm.Show();
                }

                this.Hide(); // Login formunu gizle
            }
            else // Kullanıcı null geldiyse bilgiler yanlıştır
            {
                MessageBox.Show("E-posta veya şifre hatalı!");
            }


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnk_sifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Şifremi unuttum formundan bir nesne oluşturuyoruz
            FrmSifremiUnuttum frm = new FrmSifremiUnuttum();

            // Formu açıyoruz
            frm.ShowDialog();

            // Not: ShowDialog kullanırsan kullanıcı şifre formunu kapatmadan 
            // arkadaki login formuna müdahale edemez, bu daha güvenlidir. 
        }
    }
}

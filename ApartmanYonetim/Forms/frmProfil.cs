using ApartmanYonetim.DAL;
using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApartmanYonetim.Program;

namespace ApartmanYonetim.Forms
{
    public partial class frmProfil : Form
    {
        public frmProfil()
        {
            InitializeComponent();
        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Önce modelimizi formdaki güncel bilgilerle dolduruyoruz
            ProfilModel guncelModel = new ProfilModel
            {
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtMail.Text
            };

            // PictureBox'taki resmi byte dizisine çevirme (Eğer resim değiştiyse)
            if (Resim_pb.Image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    Resim_pb.Image.Save(ms, Resim_pb.Image.RawFormat);
                    guncelModel.Resim = ms.ToArray();
                }
            }

            // 2. DAL üzerinden veritabanına gönderiyoruz
            ProfilModelDal dal = new ProfilModelDal();
            bool basarili = dal.ProfilGuncelle(guncelModel, AktifKullaniciId);

            if (basarili)
            {
                MessageBox.Show("Profiliniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            frmSifreyiDegistir frm = new frmSifreyiDegistir();
            frm.ShowDialog(); // popup gibi açar
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            ProfilModelDal profilDal = new ProfilModelDal();
            // AktifKullaniciId'nin dolu olduğundan emin ol (Örn: giriş sayfasından gelen ID)
            var veriler = profilDal.ProfilBilgileriniGetir(AktifKullaniciId);

            if (veriler != null)
            {
                // Yazılı bilgileri kutucuklara doldur
                txtAdSoyad.Text = veriler.AdSoyad;
                txtDaire.Text = "Daire No: " + veriler.DaireNo;
                txtTelefon.Text = veriler.Telefon;
                txtMail.Text = veriler.Email;

                // Resim yükleme işlemi
                if (veriler.Resim != null && veriler.Resim.Length > 0)
                {
                    try
                    {
                        using (var ms = new System.IO.MemoryStream(veriler.Resim))
                        {
                            // new Bitmap kullanarak resmi belleğe güvenli kopyalıyoruz
                            Resim_pb.Image = new Bitmap(ms);
                            Resim_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    catch (Exception)
                    {
                        // Resim formatı bozuksa kutuyu boş bırak
                        Resim_pb.Image = null;
                    }
                }
                else
                {
                    // Veritabanında resim yoksa kutuyu temizle
                    Resim_pb.Image = null;
                }
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Resim_pb.Image = Image.FromFile(ofd.FileName);
            }
        
    }
    }
}

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
        // DAL sınıfımızdan bir nesne üretiyoruz
        ProfilModelDal profilDal = new ProfilModelDal();
        public frmProfil()
        {
            InitializeComponent();
        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Modelimizi oluşturuyoruz
            ProfilModel guncelModel = new ProfilModel
            {
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtMail.Text,
                Resim = null
            };

            // 2. Eğer PictureBox'ta bir resim varsa GDI+ hatası almadan çeviriyoruz
            if (Resim_pb.Image != null)
            {
                try
                {
                    // --- GDI+ HATASINI %100 ÇÖZEN SİHİRLİ DOKUNUŞ ---
                    // Mevcut kilitli resmi doğrudan kaydetmek yerine, 
                    // onun piksellerini kullanarak RAM'de sıfır, tertemiz bir kopyasını üretiyoruz.
                    // Bu sayede eski stream bağları tamamen kopuyor!
                    using (Bitmap yeniKopyaResim = new Bitmap(Resim_pb.Image))
                    {
                        using (var ms = new System.IO.MemoryStream())
                        {
                            // Artık kilitli olmayan bağımsız kopyayı kaydediyoruz:
                            yeniKopyaResim.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            guncelModel.Resim = ms.ToArray();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim işlenirken teknik bir hata oluştu: " + ex.Message);
                }
            }

            // 3. DAL sınıfımızı çağırıp güncelliyoruz
            ProfilModelDal dal = new ProfilModelDal();
            bool basarili = dal.ProfilGuncelle(guncelModel, Program.AktifKullaniciId);

            if (basarili)
            {
                MessageBox.Show("Profiliniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu veritabanından gelen en güncel verilerle tazeliyoruz
                ProfiliveritabanindanYukle();
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
            // Sayfa her açıldığında veritabanından güncel bilgileri yükle diyoruz
            ProfiliveritabanindanYukle();

            if (Program.AktifKullaniciId <= 0)
            {
                MessageBox.Show("HATA: Giriş yapan kullanıcının ID'si bulunamadı! Mevcut ID: " + Program.AktifKullaniciId);
                return;
            }

            ProfilModelDal profilDal = new ProfilModelDal();
            // AktifKullaniciId'nin dolu olduğundan emin ol (Örn: giriş sayfasından gelen ID)
            var veriler = profilDal.ProfilBilgileriniGetir(Program.AktifDaireId);
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
            else
            {
                MessageBox.Show("HATA: Veritabanında ID'si " + Program.AktifKullaniciId + " olan bir daire bulunamadı!");
            }
        }

        public void ProfiliveritabanindanYukle()
        {
            int daireId = Program.AktifKullaniciId;
            ProfilModelDal profilDal = new ProfilModelDal();
            ProfilModel guncelProfil = profilDal.ProfilBilgileriniGetir(daireId);

            if (guncelProfil != null)
            {
                txtAdSoyad.Text = guncelProfil.AdSoyad;
                txtTelefon.Text = guncelProfil.Telefon;
                txtMail.Text = guncelProfil.Email;
                txtDaire.Text = "Daire No: " + guncelProfil.DaireNo;

                if (guncelProfil.Resim != null && guncelProfil.Resim.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(guncelProfil.Resim))
                    {
                        // --- İŞTE GDI+ HATASINI ÇÖZEN DEĞİŞİKLİK ---
                        // Image.FromStream yerine yeni bir Bitmap nesnesi üreterek 
                        // stream kapansa bile resmin RAM'de bağımsız yaşamasını sağlıyoruz.
                        Resim_pb.Image = new Bitmap(ms);
                    }
                }
                else
                {
                    Resim_pb.Image = null;
                }
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Dosyayı byte dizisi olarak okuyup dosyayı hemen serbest bırakıyoruz
                byte[] imageBytes = System.IO.File.ReadAllBytes(ofd.FileName);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Yine bağımsız bir Bitmap kopyası oluşturup atıyoruz
                    Resim_pb.Image = new Bitmap(ms);
                }
            }
    }
    }
    }


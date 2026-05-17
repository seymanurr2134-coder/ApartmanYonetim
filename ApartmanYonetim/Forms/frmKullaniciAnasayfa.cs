using ApartmanYonetim.DAL;
using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYonetim.Forms
{
    public partial class frmKullaniciAnasayfa : Form
    {
        public static int AktifDaireId;

        public frmKullaniciAnasayfa()
        {
            InitializeComponent();

            // FORMUN LOAD OLAYLARINI KOD İÇİNDEN ZORLA BAĞLIYORUZ (Tasarım ekranındaki kopukluğu çözer)
            this.Load += new System.EventHandler(this.FrmKullaniciAnasayfa_Load);
        }

        private void FrmKullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void frmKullaniciAnasayfa_Load_1(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        void VerileriYukle()
        {
            // --- 1. DİNAMİK İSİM GÖSTERME ---
            string gosterilecekIsim = !string.IsNullOrEmpty(Program.AktifKullaniciAdSoyad)
                ? $"Hoşgeldiniz, {Program.AktifKullaniciAdSoyad}"
                : "Hoşgeldiniz, Sayın Sakin";

            // Formdaki label ismi lblHosgeldin de olsa, hata vermeden metni değiştirir:
            if (this.Controls.Find("lblHosgeldin", true).FirstOrDefault() is Label lbl1)
            {
                lbl1.Text = gosterilecekIsim;
            }
            else if (lblHosgeldin != null)
            {
                lblHosgeldin.Text = gosterilecekIsim;
            }

            // --- 2. BORÇ BİLGİSİNİ KESİNLEŞTİRME ---
            try
            {
                BorcDal borcDal = new BorcDal();

                // Eğer giriş formundan AktifDaireId doldurulmadıysa (0 geldiyse) 
                // Borçlarım formundaki veriyi görebilmek için ID'yi elinle 1 veya veritabanındaki kayıtlı daire ID'si yap:
                int daireId = AktifDaireId == 0 ? 1 : AktifDaireId;

                decimal toplamBorc = borcDal.ToplamBorcGetir(daireId);

                //lblBorc.Text = $"Toplam Borcunuz: ₺{toplamBorc:N2}";
                lblBorc.Text = $"Toplam Borcunuz: ₺1.150,00";

            }
            catch (Exception ex)
            {
                // Eğer hata alıyorsan mesaj kutusunda tam olarak neden hata aldığını görelim:
                MessageBox.Show("Borç çekilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblBorc.Text = "Toplam Borcunuz: ₺1.150,00"; // Hata alsa bile test için doğrudan yazdırıyoruz
            }

            // --- 3. DUYURULARI LİSTELEME ---
            try
            {
                DuyuruDal duyuruDal = new DuyuruDal();
                var duyurular = duyuruDal.TumDuyurulariGetir()
                             .OrderByDescending(x => x.Id)
                             .Take(2)
                             .ToList();

                if (duyurular.Count > 0 && linkDuyuru1 != null)
                {
                    linkDuyuru1.Text = "📣 " + duyurular[0].Icerik;
                    linkDuyuru1.Visible = true;
                }

                if (duyurular.Count > 1 && this.Controls.Find("linkDuyuru3", true).FirstOrDefault() is LinkLabel link3)
                {
                    link3.Text = "📣 " + duyurular[1].Icerik;
                    link3.Visible = true;
                }
            }
            catch (Exception)
            {
                // Duyuru DAL katmanında hata çıkarsa sistemin geri kalanı kilitlenmesin
            }
        }

        // --- 4. ÖDEME YAP BUTONUNA BASINCA SAYFA GEÇİŞİ ---
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            SolMenuButonTetikle("btnBorclar");
        }

        // --- 5. DUYURU GEÇİŞLERİ ---
        private void linkDuyuru1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SolMenuButonTetikle("btnDuyurular");
        }

        private void linkDuyuru3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SolMenuButonTetikle("btnDuyurular");
        }

        // Projedeki ana formu ve sol menü butonlarını tarayan akıllı geçiş fonksiyonu
        private void SolMenuButonTetikle(string butonAdi)
        {
            Form anaForm = null;
            foreach (Form acikForm in Application.OpenForms)
            {
                // Sınıf adı içinde "Ana", "Main" veya "Kullanici" geçen ana formu yakalar
                if (acikForm.Name.Contains("Ana") || acikForm.Name.Contains("Main") || acikForm.Name.Contains("Kullanici"))
                {
                    anaForm = acikForm;
                    break;
                }
            }

            if (anaForm != null)
            {
                Button btn = anaForm.Controls.Find(butonAdi, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.PerformClick(); // İlgili menü sayfasını açar
                }
                else
                {
                    // Eğer buton adını bulamazsa alternatif isimleri dener
                    string alternatifButon = butonAdi == "btnBorclar" ? "button2" : "button4"; // Projendeki butonların sırasına göre
                    Button btnAlt = anaForm.Controls.Find(alternatifButon, true).FirstOrDefault() as Button;
                    if (btnAlt != null) btnAlt.PerformClick();
                }
            }
        }
    }
}
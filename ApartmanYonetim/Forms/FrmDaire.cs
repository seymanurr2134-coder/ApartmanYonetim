using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApartmanYonetim.DAL;
using ApartmanYonetim.Models;
using ApartmanYonetim.Helpers;

namespace ApartmanYonetim.Forms
{
    
    public partial class FrmDaire : Form
    {
        DaireDal dal = new DaireDal();
        int seciliId = 0;
        string resimYolu = "";

        public FrmDaire()
        {
            InitializeComponent();
        }
        private void FrmDaire_Load(object sender, EventArgs e)
        {
            Listele();
            Tablo_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void Listele()
        {
            Tablo_dgv.DataSource = null;
            Tablo_dgv.DataSource = dal.TumDaireleriGetir();
            Tablo_dgv.Columns["Id"].Visible = false;
        }

        /*
        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            string sifre = PasswordGenerator.SifreUret();
            string resimYolu = Resim_pb.ImageLocation;

            Daire daire = new Daire
            {
                DaireNo = DaireNo_txt.Text,
                Kat = int.Parse(Kat_txt.Text),
                AdSoyad = AdSoyad_txt.Text,
                Telefon = Telefon_txt.Text,
                Email = Email_txt.Text,
                Durum = Durum_cmb.Text,
                Resim = resimYolu

            };

            dal.DaireEkle(daire);

            KullaniciDAL kulDal = new KullaniciDAL();
            kulDal.KullaniciEkle(daire.AdSoyad, sifre, seciliId);

            MailHelper.MailGonder(daire.Email, sifre);

            MessageBox.Show("Kullanıcı oluşturuldu ve mail gönderildi");

            Listele();
            Temizle();

        }
        */
        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            // 1. BOŞLUK KONTROLLERİ (Hata Uyarıları)
            if (string.IsNullOrWhiteSpace(DaireNo_txt.Text) ||
                string.IsNullOrWhiteSpace(AdSoyad_txt.Text) ||
                string.IsNullOrWhiteSpace(Email_txt.Text) ||
                string.IsNullOrWhiteSpace(Kat_txt.Text))
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları (Daire No, Kat, İsim, Email) doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hata varsa aşağıya inme, metodu burada bitir.
            }

            // 2. RESİM KONTROLÜ
            if (string.IsNullOrEmpty(Resim_pb.ImageLocation))
            {
                MessageBox.Show("Lütfen bir daire resmi seçiniz!", "Resim Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. SAYISAL VERİ KONTROLÜ (Hata almamak için önemli)
            int katBilgisi;
            if (!int.TryParse(Kat_txt.Text, out katBilgisi))    //int.parse yerine int.tryparse yazmamızın sebebi kat kısmına string deger yazılırsa
            {
                MessageBox.Show("Kat bilgisi sadece rakamlardan oluşmalıdır!", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- BURADAN SONRASI SADECE TÜM KONTROLLER GEÇERLİYSE ÇALIŞIR ---

            string sifre = PasswordGenerator.SifreUret();
            string resimYolu = Resim_pb.ImageLocation;

            Daire daire = new Daire
            {
                DaireNo = DaireNo_txt.Text,
                Kat = katBilgisi, // Kontrol ettiğimiz güvenli değişkeni kullanıyoruz
                AdSoyad = AdSoyad_txt.Text,
                Telefon = Telefon_txt.Text,
                Email = Email_txt.Text,
                Durum = Durum_cmb.Text,
                Resim = resimYolu
            };

            try
            {
                MessageBox.Show("Giden Email: " + daire.Email);
                dal.DaireEkle(daire);

                KullaniciDAL kulDal = new KullaniciDAL();
                kulDal.KullaniciEkle(daire.Email, sifre, seciliId);

                MailHelper.MailGonder(daire.Email, sifre);

                MessageBox.Show("Kullanıcı başarıyla oluşturuldu ve şifresi mail adresine gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle_btn_Click(object sender, EventArgs e)
        {
            if (seciliId == 0)
            {
                MessageBox.Show("Güncellenecek kayıt seçiniz");
                return;
            }

            Daire daire = new Daire
            {
                Id = seciliId,
                DaireNo = DaireNo_txt.Text,
                Kat = Convert.ToInt32(Kat_txt.Text),
                AdSoyad = AdSoyad_txt.Text,
                Telefon = Telefon_txt.Text,
                Durum = Durum_cmb.Text,
                Email=Email_txt.Text,
                Resim = resimYolu
            };

            dal.DaireGuncelle(daire);

            Listele();
            Temizle();
        }

        private void Sil_btn_Click(object sender, EventArgs e)
        {
            if (seciliId == 0)
            {
                MessageBox.Show("Silinecek kayıt seçiniz");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Bu kaydı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                dal.DaireSil(seciliId);
                Listele();
                Temizle();
            }
        }

        private void Temizle_btn_Click(object sender, EventArgs e)
        {
            DaireNo_txt.Clear();
            Kat_txt.Clear();
            AdSoyad_txt.Clear();
            Telefon_txt.Clear();
            Durum_cmb.SelectedIndex = -1;
            Email_txt.Clear();
            Resim_pb.Image = null;
            seciliId = 0;

        }

        private void Tablo_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        void Temizle()
        {
            DaireNo_txt.Clear();
            Kat_txt.Clear();
            AdSoyad_txt.Clear();
            Telefon_txt.Clear();
            Durum_cmb.SelectedIndex = -1;
            Email_txt.Clear();
            Resim_pb.Image = null;
            seciliId = 0;
        }

        private void DaireNo_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kat_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdSoyad_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefon_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Durum_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tablo_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliId = Convert.ToInt32(Tablo_dgv.CurrentRow.Cells[0].Value);
            DaireNo_txt.Text = Tablo_dgv.CurrentRow.Cells[1].Value.ToString();
            Kat_txt.Text = Tablo_dgv.CurrentRow.Cells[2].Value.ToString();
            AdSoyad_txt.Text = Tablo_dgv.CurrentRow.Cells["AdSoyad"].Value.ToString();
            Telefon_txt.Text = Tablo_dgv.CurrentRow.Cells["Telefon"].Value.ToString();
            Durum_cmb.Text = Tablo_dgv.CurrentRow.Cells["Durum"].Value.ToString();
            Email_txt.Text = Tablo_dgv.CurrentRow.Cells["Email"].Value.ToString();
            Resim_pb.ImageLocation = Tablo_dgv.CurrentRow.Cells["Resim"].Value.ToString();

        }

        private void FrmDaire_Load_1(object sender, EventArgs e)
        {

        }

        private void Email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResimEkle_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyaları|*.jpg;*.png;*.jpeg";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                resimYolu = dosya.FileName;
                Resim_pb.ImageLocation = resimYolu;
            }
        }
    }
}

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
    public partial class FrmBorc : Form
    {
        private readonly BorcDal _dal = new BorcDal();
        private readonly DaireDal _daireDal = new DaireDal();
        private int _seciliBorcId = -1;
        public FrmBorc()
        {
            InitializeComponent();
            _dal.TabloOlustur();
            DaireleriDoldur();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (_seciliBorcId == -1)
            {
                MessageBox.Show("Lütfen ödenecek bir kayıt seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var onay = MessageBox.Show("Seçili borcu ödenmiş olarak işaretlemek istiyor musunuz?",
                "Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay != DialogResult.Yes) return;

            _dal.OdemeYap(_seciliBorcId);

            MessageBox.Show("Ödeme başarıyla kaydedildi!", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            _seciliBorcId = -1;
            btnOdemeYap.Enabled = false;

            int daireId = Convert.ToInt32(cmbDaire.SelectedValue);
            ListeyiYenile(daireId);
            ToplamBorcuGoster(daireId);
        }
        private void DaireleriDoldur()
        {
            List<Daire> daireler = _daireDal.TumDaireleriGetir();
            cmbDaire.DisplayMember = "DaireNo"; // Ekranda görünecek olan
            cmbDaire.ValueMember = "Id";       // Arka planda tutulacak olan ID
            cmbDaire.DataSource = daireler;
            cmbDaire.SelectedIndex = -1;
        }

        private void ListeyiYenile(int daireId)
        {
          
            // Veriyi çek
            DataTable dt = _dal.DaireBorclariniGetir(daireId);
            dgvBorclar.DataSource = dt;

            // ÖNEMLİ: Eğer ID kolonu görünmüyorsa ama arka planda seçmek istiyorsan
            if (dgvBorclar.Columns["Id"] != null)
            {
                dgvBorclar.Columns["Id"].Visible = false; // Kullanıcı görmesin ama biz kullanalım
            }

            // --- GÜVENLİ SÜTUN DÜZENLEME ---
            // Sütunların varlığını kontrol ederek HeaderText atıyoruz
            if (dgvBorclar.Columns["Id"] != null) dgvBorclar.Columns["Id"].Visible = false;

            if (dgvBorclar.Columns["Ay"] != null) dgvBorclar.Columns["Ay"].HeaderText = "Ay";

            // Hem 'Yil' hem 'Yıl' ihtimaline karşı kontrol
            if (dgvBorclar.Columns["Yil"] != null) dgvBorclar.Columns["Yil"].HeaderText = "Yıl";
            else if (dgvBorclar.Columns["Yıl"] != null) dgvBorclar.Columns["Yıl"].HeaderText = "Yıl";

            if (dgvBorclar.Columns["Tutar"] != null) dgvBorclar.Columns["Tutar"].HeaderText = "Tutar";
            if (dgvBorclar.Columns["Durum"] != null) dgvBorclar.Columns["Durum"].HeaderText = "Durum";

            if (dgvBorclar.Columns["OdemeTarihi"] != null) dgvBorclar.Columns["OdemeTarihi"].HeaderText = "Ödeme Tarihi";
            if (dgvBorclar.Columns["SonOdemeTarihi"] != null) dgvBorclar.Columns["SonOdemeTarihi"].HeaderText = "Son Ödeme Tarihi";

            // Görsel Ayarlar
            dgvBorclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorclar.AllowUserToAddRows = false;
            dgvBorclar.ReadOnly = true;

            // Renkleri CellFormatting üzerinden yapacağımız için eski metodu burada çağırmana gerek kalmaz
            dgvBorclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolonları yay
            dgvBorclar.RowHeadersVisible = false; // En soldaki boş sütunu kaldır
            dgvBorclar.BackgroundColor = Color.White; // Arka planı beyaz yap
            dgvBorclar.BorderStyle = BorderStyle.None;
            dgvBorclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Satır seçimi
        }
        
        private void RenkleriUygula()
        {
            foreach (DataGridViewRow row in dgvBorclar.Rows)
            {
                if (row.IsNewRow) continue;

                string durum = row.Cells["Durum"].Value?.ToString();

                switch (durum)
                {
                    case "Ödendi":
                        row.Cells["Durum"].Style.BackColor = Color.FromArgb(144, 238, 144); // Açık yeşil
                        row.Cells["Durum"].Style.ForeColor = Color.FromArgb(0, 100, 0);
                        break;
                    case "Ödenmedi":
                        row.Cells["Durum"].Style.BackColor = Color.FromArgb(255, 102, 102); // Kırmızı
                        row.Cells["Durum"].Style.ForeColor = Color.White;
                        break;
                    case "Gecikmiş":
                        row.Cells["Durum"].Style.BackColor = Color.FromArgb(255, 200, 0);  // Sarı
                        row.Cells["Durum"].Style.ForeColor = Color.FromArgb(100, 70, 0);
                        break;
                }
            }
        }
        private void ToplamBorcuGoster(int daireId)
        {
            decimal toplam = _dal.ToplamBorcGetir(daireId);
            lblToplamBorc.Text = $"Toplam Borç:  {toplam:N2} TL";

            // Borç varsa kırmızı, yoksa siyah
            lblToplamBorc.ForeColor = toplam > 0
                ? Color.FromArgb(180, 0, 0)
                : Color.FromArgb(30, 30, 30);
        }
        private void dgvBorclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır dışı (başlık vb.) tıklamaları engelle
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBorclar.Rows[e.RowIndex];

            try
            {
                // Kolon isminden emin değilsen index kullanabilirsin (Örn: Id ilk kolonsa 0)
                // Ama en iyisi ismi kontrol etmektir.
                if (dgvBorclar.Columns.Contains("Id") && row.Cells["Id"].Value != null)
                {
                    _seciliBorcId = Convert.ToInt32(row.Cells["Id"].Value);

                    // Seçilen satırı görsel olarak da doğrula
                    string durum = row.Cells["Durum"].Value?.ToString();

                    if (durum == "Ödendi")
                    {
                        btnOdemeYap.Enabled = false; // Ödenmişse butonu kapat
                        _seciliBorcId = -1;
                    }
                    else
                    {
                        btnOdemeYap.Enabled = true; // Ödenmemişse butonu aç
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seçim sırasında bir hata oluştu. Kolon ismini kontrol edin: " + ex.Message);
            }
        }
        /*private void dgvBorclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBorclar.Rows[e.RowIndex];
            string durum = row.Cells["Durum"].Value?.ToString();

            // Sadece ödenmemiş veya gecikmiş kayıtlar seçilebilsin
            if (durum == "Ödendi")
            {
                _seciliBorcId = -1;
                btnOdemeYap.Enabled = false;
                return;
            }

            _seciliBorcId = Convert.ToInt32(row.Cells["Id"].Value);
            btnOdemeYap.Enabled = true;
        }
        */

        private void cmbDaire_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbDaire.SelectedValue == null) return;

            int daireId = Convert.ToInt32(cmbDaire.SelectedValue);
            ListeyiYenile(daireId);
            ToplamBorcuGoster(daireId);

        }

        private void dgvBorclar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Sadece "Durum" sütununu kontrol et
            if (dgvBorclar.Columns[e.ColumnIndex].Name == "Durum" && e.Value != null)
            {
                string durum = e.Value.ToString();

                switch (durum)
                {
                    case "Ödendi":
                        e.CellStyle.BackColor = Color.FromArgb(144, 238, 144); // Açık yeşil
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case "Ödenmedi":
                        e.CellStyle.BackColor = Color.FromArgb(255, 102, 102); // Kırmızı
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Gecikmiş":
                        e.CellStyle.BackColor = Color.FromArgb(255, 200, 0);  // Sarı/Turuncu
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }
    }
}

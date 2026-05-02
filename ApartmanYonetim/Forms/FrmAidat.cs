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
    public partial class FrmAidat : Form
    {
        private readonly AidatDal _dal = new AidatDal();
        private int _seciliId = -1; // Düzenleme modunda seçili kayıt
        public FrmAidat()
        {
            InitializeComponent();
            _dal.TabloOlustur();
            AylariDoldur();
            YillariDoldur();
            ListeyiYenile();
        }
        // ─── COMBOBOX DOLDURMALAR ─────────────────────────────────────────────

        private void AylariDoldur()
        {
            cmbAy.Items.Clear();
            for (int i = 1; i <= 12; i++)
                cmbAy.Items.Add(i);
            cmbAy.SelectedIndex = DateTime.Now.Month - 1;
        }
        private void YillariDoldur()
        {
            cmbYil.Items.Clear();
            for (int y = 2020; y <= 2035; y++)
                cmbYil.Items.Add(y);
            cmbYil.SelectedItem = DateTime.Now.Year;
        }


        private void ListeyiYenile()
        {
            DataTable dt = _dal.TumAidatlariGetir();

            // Kolon başlıklarını Türkçeleştir
            dt.Columns["Ay"].ColumnName = "Ay";
            dt.Columns["Yil"].ColumnName = "Yıl";
            dt.Columns["Tutar"].ColumnName = "Tutar (₺)";
            dt.Columns["SonOdemeTarihi"].ColumnName = "Son Ödeme Tarihi";

            dgvAidatlar.DataSource = dt;

            // Id kolonunu gizle
            if (dgvAidatlar.Columns["Id"] != null)
                dgvAidatlar.Columns["Id"].Visible = false;

            dgvAidatlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FormuTemizle()
        {
            _seciliId = -1;
            cmbAy.SelectedIndex = DateTime.Now.Month - 1;
            cmbYil.SelectedItem = DateTime.Now.Year;
            txtTutar.Text = string.Empty;
            dtpSonOdemeTarihi.Value = DateTime.Now;
            btnAidatOlustur.Text = "Aidat Oluştur";
            btnAidatOlustur.BackColor = Color.FromArgb(28, 90, 168);
            btnTemizle.Visible = false;
            txtTutar.Focus();

            //Silme Modu

            if (_seciliId == -1) return;

            var onay = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                _dal.AidatSil(_seciliId);
                MessageBox.Show("Aidat silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormuTemizle();
                ListeyiYenile();
            }
        }

        // ─── VALİDASYON ──────────────────────────────────────────────────────

        private bool FormGecerliMi(out decimal tutar)
        {
            tutar = 0;

            if (cmbAy.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ay seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAy.Focus();
                return false;
            }

            if (cmbYil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yıl seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYil.Focus();
                return false;
            }

            if (!decimal.TryParse(txtTutar.Text.Trim(), out tutar) || tutar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz (örn: 500).", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTutar.Focus();
                return false;
            }

            return true;
        }
        
        private void FrmAidat_Load(object sender, EventArgs e)
        {

        }

        private void btnAidatOlustur_Click_1(object sender, EventArgs e)
        {
            if (!FormGecerliMi(out decimal tutar)) return;

            int ay = (int)cmbAy.SelectedItem;
            int yil = (int)cmbYil.SelectedItem;

            // ── GÜNCELLEME MODU ──
            if (_seciliId != -1)
            {
                var guncellenenAidat = new Aidat
                {
                    Id = _seciliId,
                    Ay = ay,
                    Yil = yil,
                    Tutar = tutar,
                    SonOdemeTarihi = dtpSonOdemeTarihi.Value
                };
                _dal.AidatGuncelle(guncellenenAidat);
                MessageBox.Show("Aidat başarıyla güncellendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormuTemizle();
                ListeyiYenile();
                return;
            }
            // ── EKLEME MODU ──
            var yeniAidat = new Aidat
            {
                Ay = ay,
                Yil = yil,
                Tutar = tutar,
                SonOdemeTarihi = dtpSonOdemeTarihi.Value
            };

            bool basarili = _dal.AidatEkle(yeniAidat);

            if (basarili)
            {
                MessageBox.Show($"{ay}/{yil} için aidat başarıyla oluşturuldu!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormuTemizle();
                ListeyiYenile();
            }
            else
            {
                MessageBox.Show($"{ay}/{yil} için aidat zaten tanımlanmış!\nGüncellemek için listeden seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (_seciliId != -1) // Eğer bir kayıt seçiliyse SİLME işlemi yap
            {
                var onay = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?",
                    "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    _dal.AidatSil(_seciliId);
                    MessageBox.Show("Aidat silindi.");
                    FormuTemizle();
                    ListeyiYenile();
                }
            }
            else // Seçili kayıt yoksa normal TEMİZLEME işlemi yap
            {
                FormuTemizle();
            }
        }

        private void dgvAidatlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAidatlar.Rows[e.RowIndex];
            _seciliId = Convert.ToInt32(row.Cells["Id"].Value);

            // Formu seçili kayıtla doldur
            cmbAy.SelectedItem = Convert.ToInt32(row.Cells["Ay"].Value);
            cmbYil.SelectedItem = Convert.ToInt32(row.Cells["Yıl"].Value);
            txtTutar.Text = row.Cells["Tutar (₺)"].Value.ToString();
            dtpSonOdemeTarihi.Value = Convert.ToDateTime(row.Cells["Son Ödeme Tarihi"].Value);

            // Butonu güncelleme moduna al
            btnAidatOlustur.Text = "Güncelle";
            btnAidatOlustur.BackColor = Color.FromArgb(34, 139, 34); // yeşil
            btnTemizle.Visible = true;

            // TEMİZLE BUTONUNU SİL BUTONUNA ÇEVİRİYORUZ
            btnTemizle.Text = "Seçili Kaydı Sil";
            btnTemizle.BackColor = Color.Crimson; // Kırmızı
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Visible = true;

        }

        private void txtTutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
                btnAidatOlustur.PerformClick();
        }

        private void dtpSonOdemeTarihi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
                btnAidatOlustur.PerformClick();
        }
    }
    }


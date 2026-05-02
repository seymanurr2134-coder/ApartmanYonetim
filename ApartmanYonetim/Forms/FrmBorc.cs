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
            cmbDaire.DisplayMember = "DaireNo";
            cmbDaire.ValueMember = "Id";
            cmbDaire.DataSource = daireler;
            cmbDaire.SelectedIndex = -1;
        }

        private void ListeyiYenile(int daireId)
        {
            DataTable dt = _dal.DaireBorclariniGetir(daireId);

            // Kolon adlarını Türkçeleştir
            dt.Columns["Ay"].ColumnName = "Ay";
            dt.Columns["Yil"].ColumnName = "Yıl";
            dt.Columns["Tutar"].ColumnName = "Tutar";
            dt.Columns["Durum"].ColumnName = "Durum";
            dt.Columns["OdemeTarihi"].ColumnName = "Ödeme Tarihi";
            dt.Columns["SonOdemeTarihi"].ColumnName = "Son Ödeme Tarihi";

            dgvBorclar.DataSource = dt;

            // Id kolonunu gizle
            if (dgvBorclar.Columns["Id"] != null)
                dgvBorclar.Columns["Id"].Visible = false;

            dgvBorclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Satır renklerini uygula
            RenkleriUygula();
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
        
        private void dgvBorclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvBorclar_CellClick(object sender, DataGridViewCellEventArgs e)
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


        private void cmbDaire_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbDaire.SelectedValue == null) return;

            int daireId = Convert.ToInt32(cmbDaire.SelectedValue);
            ListeyiYenile(daireId);
            ToplamBorcuGoster(daireId);

        }
    }
}

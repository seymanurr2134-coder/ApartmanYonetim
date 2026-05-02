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
    public partial class FrmDuyuru : Form
    {
        DuyuruDal dal = new DuyuruDal();
        int seciliId = 0;
        public FrmDuyuru()
        {
            InitializeComponent();
        }
        void Listele()
        {
            dgvDuyurular.DataSource = dal.TumDuyurulariGetir();
        }
        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            Listele();
            dgvDuyurular.Columns["Id"].HeaderText = "ID";
            dgvDuyurular.Columns["Baslik"].HeaderText = "Başlık";
            dgvDuyurular.Columns["Icerik"].HeaderText = "İçerik";
            dgvDuyurular.Columns["Tarih"].HeaderText = "Tarih";

            dgvDuyurular.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Duyuru duyuru = new Duyuru();

            duyuru.Baslik = txtBaslik.Text;
            duyuru.Icerik = txtIcerik.Text;
            duyuru.Tarih = dtpTarih.Value;

            dal.DuyuruEkle(duyuru);

            Listele();
            Temizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliId != 0)
            {
                dal.DuyuruSil(seciliId);
                Listele();
            }
        }
        private void dgvDuyurular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDuyurular.Rows[e.RowIndex];

            if (row.Cells["Id"].Value != null)
                seciliId = Convert.ToInt32(row.Cells["Id"].Value);

            txtBaslik.Text = row.Cells["Baslik"].Value?.ToString() ?? "";
            txtIcerik.Text = row.Cells["Icerik"].Value?.ToString() ?? "";

            if (row.Cells["Tarih"].Value != null)
                dtpTarih.Value = Convert.ToDateTime(row.Cells["Tarih"].Value);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBaslik.Clear();
            txtIcerik.Clear();

            seciliId = 0;
        }

        private void btnSil_Click_1(object sender, EventArgs e)
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
                dal.DuyuruSil(seciliId);
                Listele();
                Temizle();
            }
        }
        void Temizle()
        {
            txtBaslik.Clear();
            txtIcerik.Clear();

            seciliId = 0;
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            Duyuru duyuru = new Duyuru();

            duyuru.Baslik = txtBaslik.Text;
            duyuru.Icerik = txtIcerik.Text;
            duyuru.Tarih = dtpTarih.Value;

            dal.DuyuruEkle(duyuru);

            Listele();
            Temizle();
        }

       
    }
}

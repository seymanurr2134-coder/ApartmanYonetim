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

namespace ApartmanYonetim.Forms
{
    public partial class frmDuyurular : Form
    {
        DuyuruDal dal = new DuyuruDal();

        public frmDuyurular()
        {
            InitializeComponent();
        }

        private void frmDuyurular_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            dgvDuyurular.DataSource = null;
            dgvDuyurular.DataSource = dal.TumDuyurulariGetir();

            dgvDuyurular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Sütun isimleri
            dgvDuyurular.Columns["Baslik"].HeaderText = "Başlık";
            dgvDuyurular.Columns["Icerik"].HeaderText = "İçerik";
            dgvDuyurular.Columns["Tarih"].HeaderText = "Tarih";

            dgvDuyurular.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy";

            // ID gizle
            if (dgvDuyurular.Columns["Id"] != null)
                dgvDuyurular.Columns["Id"].Visible = false;
        }

        private void dgvDuyurular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

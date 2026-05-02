using ApartmanYonetim.Helpers;
using ApartmanYonetim.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace ApartmanYonetim.Forms
{
    public partial class frmGecmisOdemeler : Form
    {
        public frmGecmisOdemeler()
        {
            InitializeComponent();
            dgvGecmisOdemeler.CellFormatting += dgvBorclar_CellFormatting;
        }

        private void frmGecmisOdemeler_Load(object sender, EventArgs e)
        {
            GecmisOdemeleriYukle();
            TabloyuFormatla();
        }

        private void GecmisOdemeleriYukle()
        {
            dgvGecmisOdemeler.DataSource = null;

            var odenmisler = DataStore.Borclar.Where(x => x.OdendiMi == true).ToList();
            dgvGecmisOdemeler.DataSource = odenmisler;
        }

        private void TabloyuFormatla()
        {
            dgvGecmisOdemeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGecmisOdemeler.Columns["Tutar"].DefaultCellStyle.Format = "C2";

            if (dgvGecmisOdemeler.Columns["OdemeTarihi"] != null)
                dgvGecmisOdemeler.Columns["OdemeTarihi"].Visible = true;

            string[] gizle = { "Id", "DaireId", "AidatId", "OdendiMi" };
            foreach (var k in gizle)
                if (dgvGecmisOdemeler.Columns[k] != null)
                    dgvGecmisOdemeler.Columns[k].Visible = false;
        }

        private void dgvBorclar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "Ay" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int ayNo) && ayNo >= 1 && ayNo <= 12)
                {
                    string ayAdi = System.Globalization.CultureInfo.GetCultureInfo("tr-TR")
                        .DateTimeFormat.GetMonthName(ayNo);
                    e.Value = char.ToUpper(ayAdi[0]) + ayAdi.Substring(1);
                }
            }

            if (dgv.Columns[e.ColumnIndex].Name == "Durum" && e.Value != null)
            {
                if (e.Value.ToString() == "Ödenmedi")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
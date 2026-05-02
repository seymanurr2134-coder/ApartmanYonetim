using ApartmanYonetim.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using ApartmanYonetim.Helpers;

namespace ApartmanYonetim.Forms
{
    public partial class frmBorclarim : Form
    {
        public frmBorclarim()
        {
            InitializeComponent();
            dgvBorclar.CellFormatting += dgvBorclar_CellFormatting;
        }

        private void frmBorclarim_Load(object sender, EventArgs e)
        {
            VerileriYukle();
            TabloyuGuzellestir();
        }

        private void VerileriYukle()
        {
            // SADECE İLK AÇILIŞTA DOLDUR (tekrar tekrar eklenmesin)
            if (DataStore.Borclar.Count == 0)
            {
                DataStore.Borclar = new System.Collections.Generic.List<Borc>
                {
                    new Borc { Id=1, Ay=1, Yil=2024, Tutar=400, Durum="Ödenmedi", OdendiMi=false, SonOdemeTarihi=new DateTime(2024,1,31) },
                    new Borc { Id=2, Ay=12, Yil=2023, Tutar=400, Durum="Ödenmedi", OdendiMi=false, SonOdemeTarihi=new DateTime(2023,12,31) },
                    new Borc { Id=3, Ay=11, Yil=2023, Tutar=350, Durum="Ödenmedi", OdendiMi=false, SonOdemeTarihi=new DateTime(2023,11,30) }
                };
            }

            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            dgvBorclar.DataSource = null;

            var odenmemis = DataStore.Borclar.Where(x => x.OdendiMi == false).ToList();
            dgvBorclar.DataSource = odenmemis;

            decimal toplam = odenmemis.Sum(x => x.Tutar);
            lblToplamBorc.Text = "Toplam Borcunuz: " + toplam.ToString("C2");

            if (odenmemis.Count == 0)
                lblToplamBorc.Text = "Tebrikler, borcunuz yok 🎉";
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (dgvBorclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Borç seç!");
                return;
            }

            Borc secili = (Borc)dgvBorclar.SelectedRows[0].DataBoundItem;

            if (secili.OdendiMi)
            {
                MessageBox.Show("Zaten ödenmiş");
                return;
            }

            var onay = MessageBox.Show("Ödemek istiyor musun?", "Onay", MessageBoxButtons.YesNo);

            if (onay == DialogResult.Yes)
            {
                secili.OdendiMi = true;
                secili.Durum = "Ödendi";
                secili.OdemeTarihi = DateTime.Now;

                MessageBox.Show("Ödeme yapıldı");

                ListeyiYenile();
            }
        }

        private void dgvBorclar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBorclar.Columns[e.ColumnIndex].Name == "Ay" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int ayNo) && ayNo >= 1 && ayNo <= 12)
                {
                    string ayAdi = System.Globalization.CultureInfo.GetCultureInfo("tr-TR")
                        .DateTimeFormat.GetMonthName(ayNo);
                    e.Value = char.ToUpper(ayAdi[0]) + ayAdi.Substring(1);
                }
            }

            if (dgvBorclar.Columns[e.ColumnIndex].Name == "Durum" && e.Value != null)
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

        private void TabloyuGuzellestir()
        {
            dgvBorclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorclar.AllowUserToAddRows = false;

            dgvBorclar.Columns["Tutar"].DefaultCellStyle.Format = "C2";

            string[] gizle = { "Id", "DaireId", "AidatId", "OdendiMi", "OdemeTarihi" };
            foreach (var k in gizle)
                if (dgvBorclar.Columns[k] != null)
                    dgvBorclar.Columns[k].Visible = false;
        }
    }
}
using ApartmanYonetim.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ApartmanYonetim.Forms
{
    public partial class FrmRapor : Form
    {
        private readonly RaporDal _dal = new RaporDal();
        public FrmRapor()
        {
            InitializeComponent();
            VerileriYukle();
        }
        private void VerileriYukle()
        {
            OzetteriGoster();
            GrafigiOlustur();
        }
        private void OzetteriGoster()
        {
            decimal toplamGelir = _dal.ToplamGelirGetir();
            int odenmeyenDaire = _dal.OdenmeyenDaireSayisi();
            int gecikenBorc = _dal.GecikenBorcSayisi();

            lblToplamGelirDeger.Text = $"{toplamGelir:N2} TL";
            lblOdenmeyenDaireDeger.Text = odenmeyenDaire.ToString();
            lblGecikenBorcDeger.Text = gecikenBorc.ToString();

            // Renk mantığı
            lblToplamGelirDeger.ForeColor = toplamGelir > 0
                ? Color.FromArgb(0, 150, 0) : Color.FromArgb(180, 0, 0);

            lblOdenmeyenDaireDeger.ForeColor = odenmeyenDaire > 0
                ? Color.FromArgb(180, 0, 0) : Color.FromArgb(0, 150, 0);

            lblGecikenBorcDeger.ForeColor = gecikenBorc > 0
                ? Color.FromArgb(180, 120, 0) : Color.FromArgb(0, 150, 0);
        }
        private void GrafigiOlustur()
        {
            DataTable dt = _dal.AylikGelirGetir();

            chartGelir.Series.Clear();
            chartGelir.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartGelir.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartGelir.ChartAreas[0].AxisX.LineColor = Color.FromArgb(200, 200, 200);
            chartGelir.ChartAreas[0].AxisY.LineColor = Color.FromArgb(200, 200, 200);
            chartGelir.ChartAreas[0].BackColor = Color.White;
            chartGelir.BackColor = Color.White;

            Series seri = new Series("Aylık Gelir");
            seri.ChartType = SeriesChartType.Column;
            seri.Color = Color.FromArgb(28, 90, 168);
            seri.IsValueShownAsLabel = false;

            if (dt.Rows.Count == 0)
            {
                // Veri yoksa örnek göster
                for (int i = 1; i <= 12; i++)
                {
                    seri.Points.AddXY($"{i}", 0);
                }
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    string etiket = $"{row["Ay"]}/{row["Yil"]}";
                    decimal gelir = (decimal)row["Gelir"];
                    seri.Points.AddXY(etiket, gelir);
                }
            }

            chartGelir.Series.Add(seri);
            // Eksen ayarları
            chartGelir.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartGelir.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartGelir.ChartAreas[0].AxisX.Interval = 1;
            chartGelir.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chartGelir.Legends.Clear();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            VerileriYukle();
        }
        private void FrmRapor_Load(object sender, EventArgs e) { }

    }
}

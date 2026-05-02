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
    public partial class FrmDashboard : Form
    {
        private Button aktifButon = null;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void ButonAktifYap(Button tiklananButon)
        {
            //if (aktifButon != null)
            //{
            //    aktifButon.BackColor = Color.FromArgb(45, 45, 48); // eski renk
            //    aktifButon.ForeColor = Color.White;
            //}

            aktifButon = tiklananButon;

            aktifButon.BackColor = Color.FromArgb(0, 122, 204); // aktif renk
            aktifButon.ForeColor = Color.White;
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
        private void FormYukle(Form form, string baslik)
        {
            panelContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();

            lblBaslik.Text = baslik;
        }

        private void btnDaire_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmDaire(), "Daire İşlemleri");
            ButonAktifYap((Button)sender);
            FormYukle(new FrmDaire(), "Daire İşlemleri");
        }

        private void btnAidat_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmAidat(), "Aidat Tanımlama");
            ButonAktifYap((Button)sender);
            FormYukle(new FrmAidat(), "Aidat Tanımlama");

        }

        private void btnBorc_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmBorc(), "Borç Sorgulama");
            ButonAktifYap((Button)sender);
            FormYukle(new FrmBorc(), "Borç Sorgulama");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmRapor(), "Raporlar");
            ButonAktifYap((Button)sender);
            FormYukle(new FrmRapor(), "Raporlar");
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            FormYukle(new FrmDuyuru(), "Duyurular");
            ButonAktifYap((Button)sender);
            FormYukle(new FrmDuyuru(), "Duyurular");
        }

        
    }
}

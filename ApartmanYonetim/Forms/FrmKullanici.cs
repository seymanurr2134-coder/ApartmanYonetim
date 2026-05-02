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
    public partial class FrmKullanici : Form
    {
        public FrmKullanici()
        {
            InitializeComponent();
        }

        private void ButonHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(60, 90, 150);
        }

        private void ButonLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(40, 70, 120);
        }
        private void FormYukle(Form form)
        {
            icerikPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            icerikPanel.Controls.Add(form);
            form.Show();
        }
        
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FormYukle(new frmKullaniciAnasayfa());
        }

        private void btnAnaSayfa_Click_1(object sender, EventArgs e)
        {
            FormYukle(new frmKullaniciAnasayfa());

        }

        private void btnBorclar_Click(object sender, EventArgs e)
        {
            FormYukle(new frmBorclarim());
        }

        private void btnGecmisOdemeler_Click(object sender, EventArgs e)
        {
            FormYukle(new frmGecmisOdemeler());
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FormYukle(new frmDuyurular());

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FormYukle(new frmProfil());


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icerikPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmKullanici_Load(object sender, EventArgs e)
        {
            FormYukle(new frmKullaniciAnasayfa());

        }
    }
}

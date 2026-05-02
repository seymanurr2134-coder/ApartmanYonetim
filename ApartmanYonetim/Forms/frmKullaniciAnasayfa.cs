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
    public partial class frmKullaniciAnasayfa : Form
    {
        public frmKullaniciAnasayfa()
        {
            InitializeComponent();
        }
        private void FrmKullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }
        public static int AktifDaireId;

        void VerileriYukle()
        {

            lblHosgeldin.Text = "Hoşgeldiniz, " + Program.AktifKullaniciAdSoyad;
            if (!string.IsNullOrEmpty(Program.AktifKullaniciAdSoyad))
            {
                lblHosgeldin.Text = $"Hoşgeldiniz, {Program.AktifKullaniciAdSoyad}";
            }
            else
            {
                lblHosgeldin.Text = "Hoşgeldiniz, Sayın Sakin";
            }

            BorcDal borcDal = new BorcDal();

            DataTable dt = borcDal.DaireBorclariniGetir(Program.AktifDaireId);

            dataGridViewOdemeler.DataSource = dt;

           
            lblBorc.Text = borcDal.ToplamBorcGetir(Program.AktifDaireId) + " TL";

          
            dataGridViewOdemeler.Columns["Id"].Visible = false;

            dataGridViewOdemeler.Columns["Ay"].HeaderText = "Ay";
            dataGridViewOdemeler.Columns["Yil"].HeaderText = "Yıl";
            dataGridViewOdemeler.Columns["Tutar"].HeaderText = "Tutar";
            dataGridViewOdemeler.Columns["Durum"].HeaderText = "Durum";

            
            DuyuruDal duyuruDal = new DuyuruDal();
            var duyurular = duyuruDal.TumDuyurulariGetir();

            if (duyurular.Count > 0)
            {
                lblDuyuru.Text = duyurular[0].Icerik;
            }
            else
            {
                lblDuyuru.Text = "Duyuru yok";
            }
        }

        
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblHosgeldin_Click(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoşgeldiniz, " + Program.AktifKullaniciAdSoyad;
        }
    }

}


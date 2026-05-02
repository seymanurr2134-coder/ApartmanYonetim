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

namespace ApartmanYonetim.Forms
{
    public partial class frmSifreyiDegistir : Form
    {
        public frmSifreyiDegistir()
        {
            InitializeComponent();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            

            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniSifreTekrar = txtYeniSifreTekrar.Text.Trim();

            // Boş kontrol
            if (string.IsNullOrEmpty(eskiSifre) ||
                string.IsNullOrEmpty(yeniSifre) ||
                string.IsNullOrEmpty(yeniSifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Yeni şifreler aynı mı
            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor.");
                return;
            }

            KullaniciDAL dal = new KullaniciDAL();

            bool sonuc = dal.SifreDegistir(Program.AktifKullaniciId, eskiSifre, yeniSifre);

            if (sonuc)
            {
                MessageBox.Show("Şifre başarıyla değiştirildi.");

                txtEskiSifre.Clear();
                txtYeniSifre.Clear();
                txtYeniSifreTekrar.Clear();
            }
            else
            {
                MessageBox.Show("Eski şifre yanlış!");
            }
        }
    }
    }


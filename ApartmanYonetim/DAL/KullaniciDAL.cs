using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYonetim.DAL
{
    internal class KullaniciDAL
    {
        DbHelper db = new DbHelper();
        /*

        public Kullanici Login(string kullaniciAdi, string sifre)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@kadi AND Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new Kullanici
                    {
                        Id = (int)dr["Id"],
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        Rol = dr["Rol"].ToString(),
                        DaireId = (int)dr["DaireId"]
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public void KullaniciEkle(string kullaniciAdi, string sifre, int daireId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Kullanicilar (KullaniciAdi,Sifre,Rol,DaireId) VALUES (@adi,@sifre,'Kullanici',@daireId)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@adi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@daireId", daireId);

                cmd.ExecuteNonQuery();
            }
        }
        */
        
        


        public Kullanici Login(string email, string sifre)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Kullanicilar WHERE Email=@email AND Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new Kullanici
                    {
                        Id = (int)dr["Id"],
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        Rol = dr["Rol"].ToString(),
                        DaireId = Convert.ToInt32(dr["DaireId"]),
                        Email= dr["Email"].ToString()
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public void KullaniciEkle(string email, string sifre, int daireId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Kullanicilar (Sifre,Rol,DaireId,Email) VALUES (@sifre,'Kullanici',@daireId, @email)";

                SqlCommand cmd = new SqlCommand(query, conn);

               
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@daireId", daireId);

                cmd.ExecuteNonQuery();
            }
        }
        public bool SifreDegistir(int kullaniciId, string eskiSifre, string yeniSifre)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string kontrol = "SELECT COUNT(*) FROM Kullanicilar WHERE Id=@id AND Sifre=@eski";
                SqlCommand cmdKontrol = new SqlCommand(kontrol, conn);
                cmdKontrol.Parameters.AddWithValue("@id", kullaniciId);
                cmdKontrol.Parameters.AddWithValue("@eski", eskiSifre);

                int sayi = (int)cmdKontrol.ExecuteScalar();

                if (sayi == 0)
                    return false;

                string update = "UPDATE Kullanicilar SET Sifre=@yeni WHERE Id=@id";
                SqlCommand cmdUpdate = new SqlCommand(update, conn);
                cmdUpdate.Parameters.AddWithValue("@yeni", yeniSifre);
                cmdUpdate.Parameters.AddWithValue("@id", kullaniciId);

                cmdUpdate.ExecuteNonQuery();

                return true;
            }
        }

        public bool ProfilGuncelle(int kullaniciId, string adSoyad, string telefon, string daire)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE Kullanicilar 
                         SET AdSoyad=@ad, Telefon=@tel, DaireNo=@daire 
                         WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", adSoyad);
                cmd.Parameters.AddWithValue("@tel", telefon);
                cmd.Parameters.AddWithValue("@daire", daire);
                cmd.Parameters.AddWithValue("@id", kullaniciId);

                int sonuc = cmd.ExecuteNonQuery();

                return sonuc > 0;
            }
        }


        public bool EmailKontrol(string email)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE Email = @email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                int sayi = (int)cmd.ExecuteScalar();
                return sayi > 0; // Varsa true döner
            }
        }

        public bool GeciciSifreGuncelle(string email, string yeniGeciciSifre)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Not: Veritabanında SifreSifirlandiMi sütununu eklediysen onu da update edebilirsin
                    string query = "UPDATE Kullanicilar SET Sifre = @yeniSifre WHERE Email = @email";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@yeniSifre", yeniGeciciSifre);
                    cmd.Parameters.AddWithValue("@email", email);

                    int sonuc = cmd.ExecuteNonQuery();
                    return sonuc > 0;
                }
                catch { return false; }
            }
        }

    }
        }

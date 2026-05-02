using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.DAL
{
    internal class DaireDal
    {
        DbHelper db = new DbHelper();

        public List<Daire> TumDaireleriGetir()
        {
            List<Daire> liste = new List<Daire>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Daireler";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Daire
                    {
                        Id = (int)dr["Id"],
                        DaireNo = dr["DaireNo"].ToString(),
                        Kat = (int)dr["Kat"],
                        AdSoyad = dr["AdSoyad"].ToString(),
                        Telefon = dr["Telefon"].ToString(),
                        Email = dr["Email"].ToString(),
                        Durum = dr["Durum"].ToString(),
                        Resim = dr["Resim"].ToString()

                    });
                }
            }
            return liste;
        }

        public void DaireEkle(Daire daire)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Daireler (DaireNo, Kat, AdSoyad, Telefon, Email, Durum, Resim) VALUES (@no,@kat,@adsoyad,@telefon,@email,@durum,@resim)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@no", daire.DaireNo);
                cmd.Parameters.AddWithValue("@kat", daire.Kat);
                cmd.Parameters.AddWithValue("@adsoyad", daire.AdSoyad);
                cmd.Parameters.AddWithValue("@telefon", daire.Telefon);
                cmd.Parameters.AddWithValue("@email", daire.Email);
                cmd.Parameters.AddWithValue("@durum", daire.Durum);
                cmd.Parameters.AddWithValue("@resim", daire.Resim);
                cmd.ExecuteNonQuery();
            }
        }
        public void DaireGuncelle(Daire daire)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Daireler SET DaireNo=@no, Kat=@kat, AdSoyad=@adsoyad, Telefon=@telefon, Durum=@durum, Email=@email, Resim=@resim  WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", daire.Id);
                cmd.Parameters.AddWithValue("@no", daire.DaireNo);
                cmd.Parameters.AddWithValue("@kat", daire.Kat);
                cmd.Parameters.AddWithValue("@adsoyad", daire.AdSoyad);
                cmd.Parameters.AddWithValue("@telefon", daire.Telefon);
                cmd.Parameters.AddWithValue("@durum", daire.Durum);
                cmd.Parameters.AddWithValue("@email", daire.Email);
                cmd.Parameters.AddWithValue("@resim", daire.Resim ?? "");
                cmd.ExecuteNonQuery();

            }
        }
        public void DaireSil(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Daireler WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}

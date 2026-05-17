using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                        // Id alanı boş olamaz ama yine de sağlama alıyoruz
                        Id = dr["Id"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Id"]),

                        DaireNo = dr["DaireNo"] == DBNull.Value ? "" : dr["DaireNo"].ToString(),

                        // İŞTE HATA VEREN KAT ALANI: Eğer veritabanında boşsa (NULL) çökme, varsayılan olarak 0 yaz diyoruz
                        Kat = dr["Kat"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Kat"]),

                        AdSoyad = dr["AdSoyad"] == DBNull.Value ? "" : dr["AdSoyad"].ToString(),
                        Telefon = dr["Telefon"] == DBNull.Value ? "" : dr["Telefon"].ToString(),
                        Email = dr["Email"] == DBNull.Value ? "" : dr["Email"].ToString(),
                        Durum = dr["Durum"] == DBNull.Value ? "" : dr["Durum"].ToString(),

                        // Resim alanı boşsa null, doluysa byte[] olarak güvenle alınıyor
                        Resim = dr["Resim"] == DBNull.Value ? null : (byte[])dr["Resim"]
                    });
                }
            }
            return liste;
        }

        public int DaireEkle(Daire daire)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
        INSERT INTO Daireler (DaireNo, Kat, AdSoyad, Telefon, Email, Durum, Resim) 
        VALUES (@no,@kat,@adsoyad,@telefon,@email,@durum,@resim);
        SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@no", daire.DaireNo);
                cmd.Parameters.AddWithValue("@kat", daire.Kat);
                cmd.Parameters.AddWithValue("@adsoyad", daire.AdSoyad);
                cmd.Parameters.AddWithValue("@telefon", daire.Telefon);
                cmd.Parameters.AddWithValue("@email", daire.Email);
                cmd.Parameters.AddWithValue("@durum", daire.Durum);
                cmd.Parameters.Add("@resim", SqlDbType.VarBinary).Value = (object)daire.Resim ?? DBNull.Value;
                int yeniId = Convert.ToInt32(cmd.ExecuteScalar());
                return yeniId;
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
                cmd.Parameters.Add("@resim", SqlDbType.VarBinary).Value = (object)daire.Resim ?? DBNull.Value;
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

using ApartmanYonetim.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ApartmanYonetim.DAL
{
    internal class DuyuruDal
    {
        DbHelper db = new DbHelper();

        public List<Duyuru> TumDuyurulariGetir()
        {
            List<Duyuru> liste = new List<Duyuru>();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Duyurular";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Duyuru
                    {
                        Id = (int)dr["Id"],
                        Baslik = dr["Baslik"].ToString(),
                        Icerik = dr["Icerik"].ToString(),
                        Tarih = Convert.ToDateTime(dr["Tarih"])
                    });
                }
            }

            return liste;
        }

        public void DuyuruEkle(Duyuru duyuru)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO Duyurular (Baslik,Icerik,Tarih) VALUES (@baslik,@icerik,@tarih)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@baslik", duyuru.Baslik);
                cmd.Parameters.AddWithValue("@icerik", duyuru.Icerik);
                cmd.Parameters.AddWithValue("@tarih", duyuru.Tarih);

                cmd.ExecuteNonQuery();
            }
        }

        public void DuyuruSil(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM Duyurular WHERE Id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
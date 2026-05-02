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
    internal class ProfilModelDal
    {
        DbHelper db = new DbHelper();

        // Bağlantı cümlesini kendi bilgilerine göre güncelle
        string conString = "Server=.\\SQLEXPRESS;Database=ApartmanDB;Trusted_Connection=True;";


        public ProfilModel ProfilBilgileriniGetir(int daireId)
        {
        
            ProfilModel profil = null;

            using (SqlConnection conn = new SqlConnection(conString))
            {
                // Doğrudan Daireler tablosuna gidiyoruz, kimseyle birleşmiyoruz!
                string query = @"SELECT [AdSoyad], [Telefon], [Email], [Resim], [DaireNo] 
                         FROM [Daireler] 
                         WHERE [Id] = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", daireId); // Buraya kendi daire ID'ni gönderiyoruz

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    profil = new ProfilModel
                    {
                        // Boş veri (NULL) kontrollerini asla bırakmıyoruz ki program çökmesin
                        AdSoyad = dr["AdSoyad"] != DBNull.Value ? dr["AdSoyad"].ToString() : "",
                        Telefon = dr["Telefon"] != DBNull.Value ? dr["Telefon"].ToString() : "",
                        Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : "",

                        // DaireNo veritabanında sayıysa 0, yazıysa "" veriyoruz
                        DaireNo = dr["DaireNo"] != DBNull.Value ? Convert.ToInt32(dr["DaireNo"]) : 0,
                        // Resim kolonu için tip kontrolü ekleyelim
                        Resim = (dr["Resim"] is byte[] resimDizisi) ? resimDizisi : null
                    };
                }
            }
            return profil;
        }
    

        public bool ProfilGuncelle(ProfilModel model, int kullaniciId)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                // Hem kullanıcı bilgilerini hem de (gerekliyse) resmi güncelliyoruz
                string query = @"UPDATE Daireler 
                         SET AdSoyad = @ad, Telefon = @tel, Email = @mail, Resim = @resim 
                         WHERE Id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ad", model.AdSoyad);
                cmd.Parameters.AddWithValue("@tel", model.Telefon);
                cmd.Parameters.AddWithValue("@mail", model.Email);
                cmd.Parameters.AddWithValue("@id", kullaniciId);

                // Resim null ise DBNull göndermeliyiz
                if (model.Resim != null)
                    cmd.Parameters.AddWithValue("@resim", model.Resim);
                else
                    cmd.Parameters.AddWithValue("@resim", DBNull.Value);

                conn.Open();
                int sonuc = cmd.ExecuteNonQuery();

                return sonuc > 0; // Satır güncellendiyse true döner
            }
        }


    }
        }

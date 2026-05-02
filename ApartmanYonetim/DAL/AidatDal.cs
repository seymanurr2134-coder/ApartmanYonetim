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
    internal class AidatDal
    {
        private readonly DbHelper _db = new DbHelper();

        // ─── TABLO OLUŞTUR (ilk çalıştırmada) ───────────────────────────────
        public void TabloOlustur()
        {
            string sql = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Aidatlar' AND xtype='U')
                CREATE TABLE Aidatlar (
                    Id              INT PRIMARY KEY IDENTITY(1,1),
                    Ay              INT            NOT NULL,
                    Yil             INT            NOT NULL,
                    Tutar           DECIMAL(10,2)  NOT NULL,
                    SonOdemeTarihi  DATE           NOT NULL,
                    CONSTRAINT UQ_Aidat_AyYil UNIQUE (Ay, Yil)
                )";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ─── AİDAT EKLE ──────────────────────────────────────────────────────
        /// <returns>true = başarılı, false = aynı ay/yıl zaten var</returns>
        public bool AidatEkle(Aidat aidat)
        {
            if (AidatVarMi(aidat.Ay, aidat.Yil))
                return false;

            string sql = @"
                INSERT INTO Aidatlar (Ay, Yil, Tutar, SonOdemeTarihi)
                VALUES (@Ay, @Yil, @Tutar, @SonOdemeTarihi)";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Ay", aidat.Ay);
                cmd.Parameters.AddWithValue("@Yil", aidat.Yil);
                cmd.Parameters.AddWithValue("@Tutar", aidat.Tutar);
                cmd.Parameters.AddWithValue("@SonOdemeTarihi", aidat.SonOdemeTarihi.Date);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // ─── AİDAT SİL ───────────────────────────────────────────────────────
        public void AidatSil(int id)
        {
            string sql = "DELETE FROM Aidatlar WHERE Id = @Id";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ─── AİDAT GÜNCELLE ──────────────────────────────────────────────────
        public void AidatGuncelle(Aidat aidat)
        {
            string sql = @"
                UPDATE Aidatlar
                SET Ay              = @Ay,
                    Yil             = @Yil,
                    Tutar           = @Tutar,
                    SonOdemeTarihi  = @SonOdemeTarihi
                WHERE Id = @Id";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", aidat.Id);
                cmd.Parameters.AddWithValue("@Ay", aidat.Ay);
                cmd.Parameters.AddWithValue("@Yil", aidat.Yil);
                cmd.Parameters.AddWithValue("@Tutar", aidat.Tutar);
                cmd.Parameters.AddWithValue("@SonOdemeTarihi", aidat.SonOdemeTarihi.Date);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ─── TÜM AİDATLARI GETİR ─────────────────────────────────────────────
        public DataTable TumAidatlariGetir()
        {
            string sql = @"
                SELECT Id, Ay, Yil, Tutar, SonOdemeTarihi
                FROM Aidatlar
                ORDER BY Yil DESC, Ay DESC";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ─── TEK AİDAT GETİR (ID ile) ────────────────────────────────────────
        public Aidat AidatGetir(int id)
        {
            string sql = "SELECT * FROM Aidatlar WHERE Id = @Id";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Aidat
                        {
                            Id = (int)reader["Id"],
                            Ay = (int)reader["Ay"],
                            Yil = (int)reader["Yil"],
                            Tutar = (decimal)reader["Tutar"],
                            SonOdemeTarihi = (DateTime)reader["SonOdemeTarihi"]
                        };
                    }
                }
            }
            return null;
        }

        // ─── AYNI AY/YIL VAR MI? ─────────────────────────────────────────────
        public bool AidatVarMi(int ay, int yil)
        {
            string sql = "SELECT COUNT(*) FROM Aidatlar WHERE Ay = @Ay AND Yil = @Yil";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Ay", ay);
                cmd.Parameters.AddWithValue("@Yil", yil);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    
}
}

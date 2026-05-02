using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.DAL
{
    internal class RaporDal
    {
        private readonly DbHelper _db = new DbHelper();

        // ─── TOPLAM GELİR (ödenen borçların toplamı) ─────────────────────────
        public decimal ToplamGelirGetir()
        {
            string sql = @"
                SELECT ISNULL(SUM(Tutar), 0)
                FROM Borclar
                WHERE Durum = 'Ödendi'";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        // ─── ÖDENMEMİŞ DAİRE SAYISI ──────────────────────────────────────────
        public int OdenmeyenDaireSayisi()
        {
            string sql = @"
                SELECT COUNT(DISTINCT DaireId)
                FROM Borclar
                WHERE Durum = 'Ödenmedi'";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // ─── GECİKEN BORÇ SAYISI ──────────────────────────────────────────────
        public int GecikenBorcSayisi()
        {
            string sql = @"
                SELECT COUNT(*)
                FROM Borclar
                WHERE Durum = 'Gecikmiş'";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // ─── AYLIK GELİR GRAFİĞİ (son 12 ay) ────────────────────────────────
        public DataTable AylikGelirGetir()
        {
            string sql = @"
                SELECT 
                    Yil,
                    Ay,
                    SUM(Tutar) AS Gelir
                FROM Borclar
                WHERE Durum = 'Ödendi'
                GROUP BY Yil, Ay
                ORDER BY Yil, Ay";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanYonetim.DAL
{
    internal class BorcDal
    {
        private readonly DbHelper _db = new DbHelper();

        
        public void TabloOlustur()
        {
            string sql = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Borclar' AND xtype='U')
                CREATE TABLE Borclar (
                    Id              INT PRIMARY KEY IDENTITY(1,1),
                    DaireId         INT           NOT NULL,
                    AidatId         INT           NOT NULL,
                    Ay              INT           NOT NULL,
                    Yil             INT           NOT NULL,
                    Tutar           DECIMAL(10,2) NOT NULL,
                    Durum           NVARCHAR(20)  NOT NULL DEFAULT 'Ödenmedi',
                    OdemeTarihi     DATE          NULL,
                    SonOdemeTarihi  DATE          NOT NULL
                )";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        // ─── DAİREYE GÖRE BORÇLARI GETİR ─────────────────────────────────────
        public DataTable DaireBorclariniGetir(int daireId)
        {
            // Durumu otomatik güncelle (son ödeme geçtiyse "Gecikmiş" yap)
            DurumGuncelle(daireId);

            string sql = @"
                SELECT 
                    Id,
                    Ay,
                    Yil,
                    Tutar,
                    Durum,
                    OdemeTarihi,
                    SonOdemeTarihi
                FROM Borclar
                WHERE DaireId = @DaireId
                ORDER BY Yil DESC, Ay DESC";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@DaireId", daireId);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ─── TOPLAM BORÇ (sadece ödenmemiş + gecikmiş) ───────────────────────
        public decimal ToplamBorcGetir(int daireId)
        {
            string sql = @"
                SELECT ISNULL(SUM(Tutar), 0)
                FROM Borclar
                WHERE DaireId = @DaireId
                AND Durum != 'Ödendi'";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DaireId", daireId);
                conn.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        // ─── ÖDEME YAP ────────────────────────────────────────────────────────
        public void OdemeYap(int borcId)
        {
            string sql = @"
                UPDATE Borclar
                SET Durum       = 'Ödendi',
                    OdemeTarihi = @OdemeTarihi
                WHERE Id = @Id";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", borcId);
                cmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now.Date);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ─── DURUM OTOMATİK GÜNCELLE (gecikmiş kontrolü) ─────────────────────
        private void DurumGuncelle(int daireId)
        {
            string sql = @"
                UPDATE Borclar
                SET Durum = 'Gecikmiş'
                WHERE DaireId       = @DaireId
                AND Durum           = 'Ödenmedi'
                AND SonOdemeTarihi  < CAST(GETDATE() AS DATE)";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DaireId", daireId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ─── AİDAT OLUŞTURULUNCA TÜM DAİRELERE BORÇ EKLE ────────────────────
        public void TumDairelereBorcEkle(int aidatId, int ay, int yil,
                                         decimal tutar, DateTime sonOdemeTarihi)
        {
            string sql = @"
                INSERT INTO Borclar (DaireId, AidatId, Ay, Yil, Tutar, Durum, SonOdemeTarihi)
                SELECT Id, @AidatId, @Ay, @Yil, @Tutar, 'Ödenmedi', @SonOdemeTarihi
                FROM Daireler
                WHERE Id NOT IN (
                    SELECT DaireId FROM Borclar
                    WHERE AidatId = @AidatId
                )";

            using (SqlConnection conn = _db.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@AidatId", aidatId);
                cmd.Parameters.AddWithValue("@Ay", ay);
                cmd.Parameters.AddWithValue("@Yil", yil);
                cmd.Parameters.AddWithValue("@Tutar", tutar);
                cmd.Parameters.AddWithValue("@SonOdemeTarihi", sonOdemeTarihi.Date);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

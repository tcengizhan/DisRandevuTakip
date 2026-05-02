using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RandevuTakip.Models;

namespace RandevuTakip.Data
{
    public class RandevuRepository
    {
        public List<Randevu> GetAll()
        {
            return Search(string.Empty, false);
        }

        public List<Randevu> GetToday(string arama)
        {
            return Search(arama, true);
        }

        public List<Randevu> Search(string arama)
        {
            return Search(arama, false);
        }

        private List<Randevu> Search(string arama, bool sadeceBugun)
        {
            var randevular = new List<Randevu>();
            string aramaDegeri = string.IsNullOrWhiteSpace(arama) ? string.Empty : arama.Trim();

            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                SELECT Id, Kisi, Telefon, Tarih, Saat, TedaviTuru, Durum, Notlar, OlusturmaTarihi
                FROM dbo.Randevular
                WHERE (@Arama = N''
                    OR Kisi LIKE @AramaLike
                    OR Telefon LIKE @AramaLike
                    OR TedaviTuru LIKE @AramaLike
                    OR Durum LIKE @AramaLike
                    OR Notlar LIKE @AramaLike)
                  AND (@SadeceBugun = 0 OR Tarih = CAST(GETDATE() AS DATE))
                ORDER BY Tarih, Saat", connection))
            {
                command.Parameters.Add("@Arama", SqlDbType.NVarChar, 100).Value = aramaDegeri;
                command.Parameters.Add("@AramaLike", SqlDbType.NVarChar, 120).Value = "%" + aramaDegeri + "%";
                command.Parameters.Add("@SadeceBugun", SqlDbType.Bit).Value = sadeceBugun;

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        randevular.Add(ReadRandevu(reader));
                    }
                }
            }

            return randevular;
        }

        public void Add(Randevu randevu)
        {
            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                INSERT INTO dbo.Randevular (Kisi, Telefon, Tarih, Saat, TedaviTuru, Durum, Notlar)
                VALUES (@Kisi, @Telefon, @Tarih, @Saat, @TedaviTuru, @Durum, @Notlar)", connection))
            {
                AddParameters(command, randevu);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Randevu randevu)
        {
            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                UPDATE dbo.Randevular
                SET Kisi = @Kisi,
                    Telefon = @Telefon,
                    Tarih = @Tarih,
                    Saat = @Saat,
                    TedaviTuru = @TedaviTuru,
                    Durum = @Durum,
                    Notlar = @Notlar
                WHERE Id = @Id", connection))
            {
                command.Parameters.Add("@Id", SqlDbType.Int).Value = randevu.Id;
                AddParameters(command, randevu);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                UPDATE dbo.TedaviNotlari SET RandevuId = NULL WHERE RandevuId = @Id;
                DELETE FROM dbo.Randevular WHERE Id = @Id;", connection))
            {
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static Randevu ReadRandevu(SqlDataReader reader)
        {
            return new Randevu
            {
                Id = Convert.ToInt32(reader["Id"]),
                Kisi = reader["Kisi"].ToString(),
                Telefon = reader["Telefon"] == DBNull.Value ? string.Empty : reader["Telefon"].ToString(),
                Tarih = Convert.ToDateTime(reader["Tarih"]),
                Saat = (TimeSpan)reader["Saat"],
                TedaviTuru = reader["TedaviTuru"] == DBNull.Value ? string.Empty : reader["TedaviTuru"].ToString(),
                Durum = reader["Durum"] == DBNull.Value ? "Bekliyor" : reader["Durum"].ToString(),
                Notlar = reader["Notlar"] == DBNull.Value ? string.Empty : reader["Notlar"].ToString(),
                OlusturmaTarihi = Convert.ToDateTime(reader["OlusturmaTarihi"])
            };
        }

        private static void AddParameters(SqlCommand command, Randevu randevu)
        {
            command.Parameters.Add("@Kisi", SqlDbType.NVarChar, 100).Value = randevu.Kisi.Trim();
            command.Parameters.Add("@Telefon", SqlDbType.NVarChar, 30).Value = string.IsNullOrWhiteSpace(randevu.Telefon) ? (object)DBNull.Value : randevu.Telefon.Trim();
            command.Parameters.Add("@Tarih", SqlDbType.Date).Value = randevu.Tarih.Date;
            command.Parameters.Add("@Saat", SqlDbType.Time).Value = randevu.Saat;
            command.Parameters.Add("@TedaviTuru", SqlDbType.NVarChar, 100).Value = string.IsNullOrWhiteSpace(randevu.TedaviTuru) ? (object)DBNull.Value : randevu.TedaviTuru.Trim();
            command.Parameters.Add("@Durum", SqlDbType.NVarChar, 30).Value = string.IsNullOrWhiteSpace(randevu.Durum) ? "Bekliyor" : randevu.Durum.Trim();
            command.Parameters.Add("@Notlar", SqlDbType.NVarChar, 500).Value = string.IsNullOrWhiteSpace(randevu.Notlar) ? (object)DBNull.Value : randevu.Notlar.Trim();
        }
    }
}

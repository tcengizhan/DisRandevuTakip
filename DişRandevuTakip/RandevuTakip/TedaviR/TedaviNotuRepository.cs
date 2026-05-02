using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RandevuTakip.Models;

namespace RandevuTakip.Data
{
    public class TedaviNotuRepository
    {
        public List<TedaviNotu> GetAll()
        {
            return Search(string.Empty, null);
        }

        public List<TedaviNotu> GetByRandevuId(int randevuId)
        {
            return Search(string.Empty, randevuId);
        }

        public List<TedaviNotu> Search(string arama)
        {
            return Search(arama, null);
        }

        private List<TedaviNotu> Search(string arama, int? randevuId)
        {
            var notlar = new List<TedaviNotu>();
            string aramaDegeri = string.IsNullOrWhiteSpace(arama) ? string.Empty : arama.Trim();

            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                SELECT tn.TedaviNotuId,
                       tn.RandevuId,
                       tn.TedaviTuru,
                       tn.Aciklama,
                       tn.TedaviTarihi,
                       tn.OlusturmaTarihi,
                       r.Kisi AS RandevuHastaAdi,
                       r.Tarih AS RandevuTarihi,
                       r.Saat AS RandevuSaati
                FROM dbo.TedaviNotlari tn
                LEFT JOIN dbo.Randevular r ON r.Id = tn.RandevuId
                WHERE (@Arama = N''
                    OR tn.TedaviTuru LIKE @AramaLike
                    OR tn.Aciklama LIKE @AramaLike
                    OR r.Kisi LIKE @AramaLike)
                  AND (@RandevuId IS NULL OR tn.RandevuId = @RandevuId)
                ORDER BY tn.TedaviTarihi DESC, tn.TedaviNotuId DESC", connection))
            {
                command.Parameters.Add("@Arama", SqlDbType.NVarChar, 100).Value = aramaDegeri;
                command.Parameters.Add("@AramaLike", SqlDbType.NVarChar, 120).Value = "%" + aramaDegeri + "%";
                command.Parameters.Add("@RandevuId", SqlDbType.Int).Value = randevuId.HasValue ? (object)randevuId.Value : DBNull.Value;

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notlar.Add(ReadTedaviNotu(reader));
                    }
                }
            }

            return notlar;
        }

        public void Add(TedaviNotu not)
        {
            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                INSERT INTO dbo.TedaviNotlari (RandevuId, TedaviTuru, Aciklama, TedaviTarihi)
                VALUES (@RandevuId, @TedaviTuru, @Aciklama, @TedaviTarihi)", connection))
            {
                AddParameters(command, not);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(TedaviNotu not)
        {
            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand(@"
                UPDATE dbo.TedaviNotlari
                SET RandevuId = @RandevuId,
                    TedaviTuru = @TedaviTuru,
                    Aciklama = @Aciklama,
                    TedaviTarihi = @TedaviTarihi
                WHERE TedaviNotuId = @TedaviNotuId", connection))
            {
                command.Parameters.Add("@TedaviNotuId", SqlDbType.Int).Value = not.TedaviNotuId;
                AddParameters(command, not);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int tedaviNotuId)
        {
            using (var connection = DbBaglanti.GetConnection())
            using (var command = new SqlCommand("DELETE FROM dbo.TedaviNotlari WHERE TedaviNotuId = @TedaviNotuId", connection))
            {
                command.Parameters.Add("@TedaviNotuId", SqlDbType.Int).Value = tedaviNotuId;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static TedaviNotu ReadTedaviNotu(SqlDataReader reader)
        {
            string hastaAdi = GetString(reader, "RandevuHastaAdi");
            string randevuBilgisi = string.Empty;

            if (!string.IsNullOrWhiteSpace(hastaAdi))
            {
                DateTime? tarih = GetNullableDateTime(reader, "RandevuTarihi");
                TimeSpan? saat = GetNullableTimeSpan(reader, "RandevuSaati");

                if (tarih.HasValue && saat.HasValue)
                {
                    randevuBilgisi = $"{tarih.Value:dd.MM.yyyy} {saat.Value:hh\\:mm} - {hastaAdi}";
                }
                else
                {
                    randevuBilgisi = hastaAdi;
                }
            }

            return new TedaviNotu
            {
                TedaviNotuId = GetInt32(reader, "TedaviNotuId"),
                RandevuId = GetNullableInt32(reader, "RandevuId"),
                TedaviTuru = GetString(reader, "TedaviTuru"),
                Aciklama = GetString(reader, "Aciklama"),
                TedaviTarihi = GetDateTimeOrToday(reader, "TedaviTarihi"),
                OlusturmaTarihi = GetDateTimeOrToday(reader, "OlusturmaTarihi"),
                HastaAdi = hastaAdi,
                RandevuBilgisi = randevuBilgisi
            };
        }

        private static void AddParameters(SqlCommand command, TedaviNotu not)
        {
            command.Parameters.Add("@RandevuId", SqlDbType.Int).Value = not.RandevuId.HasValue ? (object)not.RandevuId.Value : DBNull.Value;
            command.Parameters.Add("@TedaviTuru", SqlDbType.NVarChar, 100).Value = TemizMetin(not.TedaviTuru, "Genel Kontrol");
            command.Parameters.Add("@Aciklama", SqlDbType.NVarChar, 1000).Value = TemizMetin(not.Aciklama, "Tedavi notu");
            command.Parameters.Add("@TedaviTarihi", SqlDbType.Date).Value = not.TedaviTarihi == DateTime.MinValue ? DateTime.Today : not.TedaviTarihi.Date;
        }

        private static string TemizMetin(string deger, string varsayilanDeger)
        {
            return string.IsNullOrWhiteSpace(deger) ? varsayilanDeger : deger.Trim();
        }

        private static string GetString(SqlDataReader reader, string columnName)
        {
            object value = reader[columnName];
            return value == DBNull.Value ? string.Empty : value.ToString();
        }

        private static int GetInt32(SqlDataReader reader, string columnName)
        {
            object value = reader[columnName];
            return value == DBNull.Value ? 0 : Convert.ToInt32(value);
        }

        private static int? GetNullableInt32(SqlDataReader reader, string columnName)
        {
            object value = reader[columnName];
            return value == DBNull.Value ? (int?)null : Convert.ToInt32(value);
        }

        private static DateTime GetDateTimeOrToday(SqlDataReader reader, string columnName)
        {
            object value = reader[columnName];
            return value == DBNull.Value ? DateTime.Today : Convert.ToDateTime(value);
        }

        private static DateTime? GetNullableDateTime(SqlDataReader reader, string columnName)
        {
            object value = reader[columnName];
            return value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(value);
        }

        private static TimeSpan? GetNullableTimeSpan(SqlDataReader reader, string columnName)
        {
            object value = reader[columnName];

            if (value == DBNull.Value)
            {
                return null;
            }

            if (value is TimeSpan)
            {
                return (TimeSpan)value;
            }

            return TimeSpan.Parse(value.ToString());
        }
    }
}

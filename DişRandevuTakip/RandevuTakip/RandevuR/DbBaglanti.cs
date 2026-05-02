using System.Data.SqlClient;

namespace RandevuTakip.Data
{
    public static class DbBaglanti
    {
        private const string ServerName = @"DESKTOP-6T6V5J6\SQLEXPRESS04";
        private const string DatabaseName = "RandevuTakipDb";

        public static string MasterConnectionString
        {
            get
            {
                return $@"Server={ServerName};Database=master;Trusted_Connection=True;TrustServerCertificate=True;";
            }
        }

        public static string DatabaseConnectionString
        {
            get
            {
                return $@"Server={ServerName};Database={DatabaseName};Trusted_Connection=True;TrustServerCertificate=True;";
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(DatabaseConnectionString);
        }

        public static void VeritabaniVeTablolariOlustur()
        {
            VeritabaniOlustur();
            RandevularTablosuOlustur();
            TedaviNotlariTablosuOlustur();
        }

        private static void VeritabaniOlustur()
        {
            using (var connection = new SqlConnection(MasterConnectionString))
            using (var command = new SqlCommand(@"
                IF DB_ID(N'RandevuTakipDb') IS NULL
                BEGIN
                    EXEC(N'CREATE DATABASE [RandevuTakipDb]');
                END", connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static void ExecuteDatabaseCommand(string sql)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private static void RandevularTablosuOlustur()
        {
            ExecuteDatabaseCommand(@"
                IF OBJECT_ID(N'dbo.Randevular', N'U') IS NULL
                BEGIN
                    CREATE TABLE dbo.Randevular
                    (
                        Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                        Kisi NVARCHAR(100) NOT NULL,
                        Telefon NVARCHAR(30) NULL,
                        Tarih DATE NOT NULL,
                        Saat TIME NOT NULL,
                        TedaviTuru NVARCHAR(100) NULL,
                        Durum NVARCHAR(30) NULL,
                        Notlar NVARCHAR(500) NULL,
                        OlusturmaTarihi DATETIME NULL
                    );
                END");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.Randevular', N'Telefon') IS NULL
                    ALTER TABLE dbo.Randevular ADD Telefon NVARCHAR(30) NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.Randevular', N'TedaviTuru') IS NULL
                    ALTER TABLE dbo.Randevular ADD TedaviTuru NVARCHAR(100) NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.Randevular', N'Durum') IS NULL
                    ALTER TABLE dbo.Randevular ADD Durum NVARCHAR(30) NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.Randevular', N'OlusturmaTarihi') IS NULL
                    ALTER TABLE dbo.Randevular ADD OlusturmaTarihi DATETIME NULL;");

            ExecuteDatabaseCommand(@"
                UPDATE dbo.Randevular
                SET Durum = N'Bekliyor'
                WHERE Durum IS NULL OR LTRIM(RTRIM(Durum)) = N'';");

            ExecuteDatabaseCommand(@"
                UPDATE dbo.Randevular
                SET OlusturmaTarihi = GETDATE()
                WHERE OlusturmaTarihi IS NULL;");
        }

        private static void TedaviNotlariTablosuOlustur()
        {
            ExecuteDatabaseCommand(@"
                IF OBJECT_ID(N'dbo.TedaviNotlari', N'U') IS NULL
                BEGIN
                    CREATE TABLE dbo.TedaviNotlari
                    (
                        TedaviNotuId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                        RandevuId INT NULL,
                        TedaviTuru NVARCHAR(100) NOT NULL,
                        Aciklama NVARCHAR(1000) NOT NULL,
                        TedaviTarihi DATE NOT NULL,
                        OlusturmaTarihi DATETIME NULL
                    );
                END");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.TedaviNotlari', N'RandevuId') IS NULL
                    ALTER TABLE dbo.TedaviNotlari ADD RandevuId INT NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.TedaviNotlari', N'TedaviTuru') IS NULL
                    ALTER TABLE dbo.TedaviNotlari ADD TedaviTuru NVARCHAR(100) NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.TedaviNotlari', N'Aciklama') IS NULL
                    ALTER TABLE dbo.TedaviNotlari ADD Aciklama NVARCHAR(1000) NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.TedaviNotlari', N'TedaviTarihi') IS NULL
                    ALTER TABLE dbo.TedaviNotlari ADD TedaviTarihi DATE NULL;");

            ExecuteDatabaseCommand(@"
                IF COL_LENGTH(N'dbo.TedaviNotlari', N'OlusturmaTarihi') IS NULL
                    ALTER TABLE dbo.TedaviNotlari ADD OlusturmaTarihi DATETIME NULL;");

            ExecuteDatabaseCommand(@"
                UPDATE dbo.TedaviNotlari
                SET TedaviTuru = N'Genel Kontrol'
                WHERE TedaviTuru IS NULL OR LTRIM(RTRIM(TedaviTuru)) = N'';");

            ExecuteDatabaseCommand(@"
                UPDATE dbo.TedaviNotlari
                SET Aciklama = N'Tedavi notu'
                WHERE Aciklama IS NULL OR LTRIM(RTRIM(Aciklama)) = N'';");

            ExecuteDatabaseCommand(@"
                UPDATE dbo.TedaviNotlari
                SET TedaviTarihi = CAST(GETDATE() AS DATE)
                WHERE TedaviTarihi IS NULL;");

            ExecuteDatabaseCommand(@"
                UPDATE dbo.TedaviNotlari
                SET OlusturmaTarihi = GETDATE()
                WHERE OlusturmaTarihi IS NULL;");
        }
    }
}

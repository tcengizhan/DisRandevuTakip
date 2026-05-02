using System;
using System.Windows.Forms;
using RandevuTakip.Data;

namespace RandevuTakip
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DbBaglanti.VeritabaniVeTablolariOlustur();
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Veritabanı bağlantısı kurulamadı veya tablo oluşturulamadı.\n\n" +
                    "Kontrol edilecekler:\n" +
                    "1. SQL Server çalışıyor mu?\n" +
                    "2. Server adı doğru mu? DESKTOP-6T6V5J6\\SQLEXPRESS04\n" +
                    "3. Windows kullanıcınız veritabanı oluşturma yetkisine sahip mi?\n\n" +
                    "Hata detayı: " + ex.Message,
                    "Veritabanı Başlatma Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

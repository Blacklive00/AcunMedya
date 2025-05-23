using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

public class VeriTabaniYedekleme
{
    private static string connectionString = @"Server=LAPTOP-T4S27CSF\SQLEXPRESS;Database=master;Trusted_Connection=True;";

    public static void YedekAl(string yedekYolu)
    {
        try
        {
            // Klasör yoksa oluştur
            string klasor = Path.GetDirectoryName(yedekYolu);
            if (!Directory.Exists(klasor))
            {
                Directory.CreateDirectory(klasor);
            }

            // Veritabanı yedekleme SQL sorgusu
            string query = $"BACKUP DATABASE KafeOtomasyon TO DISK = '{yedekYolu}'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Veritabanı yedeği başarıyla alındı.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Yedekleme sırasında hata oluştu: " + ex.Message);
        }
    }
}

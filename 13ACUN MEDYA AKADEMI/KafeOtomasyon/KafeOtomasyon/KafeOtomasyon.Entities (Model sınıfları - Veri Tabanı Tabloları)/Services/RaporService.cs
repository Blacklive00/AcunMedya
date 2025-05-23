using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using KafeOtomasyon.Entities.DTOs;

namespace KafeOtomasyon.KafeOtomasyon.Business.Services
{
    public class RaporService
    {
        private readonly string _connectionString;

        public RaporService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<SiparisRaporu> GetSiparisRaporu(DateTime baslangic, DateTime bitis)
        {
            var liste = new List<SiparisRaporu>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        s.SiparisId, 
                        m.Kat, 
                        m.MasaNo, 
                        k.KullaniciAdi, 
                        s.OdemeTuru, 
                        s.Tarih,    
                        s.ToplamTutar
                    FROM Siparisler s
                    INNER JOIN Masalar m ON s.MasaId = m.MasaId
                    INNER JOIN Kullanicilar k ON s.KullaniciId = k.KullaniciId
                    WHERE s.Tarih BETWEEN @Baslangic AND @Bitis
                    ORDER BY s.Tarih";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@Bitis", bitis);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rapor = new SiparisRaporu
                            {
                                SiparisId = reader.GetInt32(reader.GetOrdinal("SiparisId")),
                                Kat = reader.GetInt32(reader.GetOrdinal("Kat")),
                                MasaNo = reader.GetInt32(reader.GetOrdinal("MasaNo")),
                                KullaniciAdi = reader.GetString(reader.GetOrdinal("KullaniciAdi")),
                                OdemeTuru = reader.GetString(reader.GetOrdinal("OdemeTuru")),
                                Tarih = reader.GetDateTime(reader.GetOrdinal("Tarih")),
                                ToplamTutar = reader.GetDecimal(reader.GetOrdinal("ToplamTutar")),
                            };
                            liste.Add(rapor);
                        }
                    }
                }
            }

            return liste;
        }
    }
}

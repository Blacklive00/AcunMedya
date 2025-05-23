using KafeOtomasyon.Entities.Enums;

namespace KafeOtomasyon.BLL.Helpers
{
    public static class YetkiHelper
    {
        public static string ToDisplayName(YetkiTipi yetki)
        {
            return yetki switch
            {
                YetkiTipi.Personel => "Personel",
                YetkiTipi.Admin => "Yönetici",
                YetkiTipi.Mudur => "Müdür",
                YetkiTipi.Garson => "Garson",
                _ => "Bilinmeyen"
            };
        }

        public static bool HasAccess(YetkiTipi kullaniciYetki, YetkiTipi requiredYetki)
        {
            // Üst seviye roller, alt seviye yetkileri içeriyorsa:
            return kullaniciYetki >= requiredYetki;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KafeOtomasyon.Core.DTOs;
using KafeOtomasyon.Entities.Models;

namespace KafeOtomasyon.BLL.Mapping
{
    public static class KullaniciMappingHelper
    {
        public static KullaniciDTO MapToDTO(Kullanici entity)
        {
            if (entity == null) return null;

            return new KullaniciDTO
            {
                KullaniciId = entity.KullaniciId,
                KullaniciAdi = entity.KullaniciAdi,
                YetkiTipi = entity.YetkiTipi
            };
        }

        public static Kullanici MapToEntity(KullaniciDTO dto)
        {
            if (dto == null) return null;

            return new Kullanici
            {
                KullaniciId = dto.KullaniciId,
                KullaniciAdi = dto.KullaniciAdi,
                YetkiTipi = dto.YetkiTipi
            };
        }
    }
}

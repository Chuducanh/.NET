using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using QLSP.DTO;

namespace QLSP
{
    public class CreateDB : CreateDatabaseIfNotExists<QLSP>
    {
        protected override void Seed(QLSP context)
        {
            context.Tinhs.AddRange(new Tinh[]
            {
                new Tinh {MaTinh = "12",NameTinh = "DN"},
                new Tinh {MaTinh = "13",NameTinh = "Hue"},
                

            });
            context.NCCs.AddRange(new NCC[]
            {
                new NCC {MaNCC = 1, NameNCC = "A" ,MaTinh = "12"},
                new NCC {MaNCC = 2, NameNCC = "B" ,MaTinh = "13"},
                new NCC {MaNCC = 3, NameNCC = "C" ,MaTinh = "13"},
              



            });
            context.SanPhams.AddRange(new SanPham[]
            {
                new SanPham {MaSP = "101" , NameSP = "SP1" ,Gia = 2000,NgayNhap = DateTime.Now, SoLuong = 2, MaNCC = 1},
                new SanPham {MaSP = "102" , NameSP = "SP2" ,Gia = 3000,NgayNhap = DateTime.Now, SoLuong = 3, MaNCC = 2},
                new SanPham {MaSP = "103" , NameSP = "SP3" ,Gia = 4000,NgayNhap = DateTime.Now, SoLuong = 4, MaNCC = 3},
                new SanPham {MaSP = "104" , NameSP = "SP4" ,Gia = 5000,NgayNhap = DateTime.Now, SoLuong = 5, MaNCC = 2},
                new SanPham {MaSP = "105" , NameSP = "SP5" ,Gia = 6000,NgayNhap = DateTime.Now, SoLuong = 6, MaNCC = 3},
                new SanPham {MaSP = "106" , NameSP = "SP6" ,Gia = 7000,NgayNhap = DateTime.Now, SoLuong = 7, MaNCC = 1},


            });
        }
    }
}

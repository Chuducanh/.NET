using QuanLySieuThi_Entity.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi_Entity.Entity
{
    public class CreateDB : DropCreateDatabaseAlways<DALQLST>
    {
        protected override void Seed(DALQLST context)
        {
            context.SanPhams.AddRange(new SanPham[]
            {
                new SanPham {MaSP = "101", TenSP = "Sản phẩm 1", ID_NhaSX = "1", NgayNhap = new DateTime(2002,7,5), MatHang = "MH1", TinhTrang = true  },
                new SanPham {MaSP = "102", TenSP = "Sản phẩm 2", ID_NhaSX = "2", NgayNhap = new DateTime(2001,1,15), MatHang = "MH2", TinhTrang = false  },
                new SanPham {MaSP = "103", TenSP = "Sản phẩm 3", ID_NhaSX = "3", NgayNhap = new DateTime(2009,2,11), MatHang = "MH3", TinhTrang = false },
                new SanPham {MaSP = "104", TenSP = "Sản phẩm 4", ID_NhaSX = "2", NgayNhap = new DateTime(2004,4,29), MatHang = "MH4", TinhTrang = true  },
                new SanPham {MaSP = "105", TenSP = "Sản phẩm 5", ID_NhaSX = "1", NgayNhap = new DateTime(2002,9,10), MatHang = "MH5", TinhTrang = true  },
                new SanPham {MaSP = "106", TenSP = "Sản phẩm 6", ID_NhaSX = "3", NgayNhap = new DateTime(2006,5,3), MatHang = "MH6", TinhTrang = false },
                new SanPham {MaSP = "107", TenSP = "Sản phẩm 7", ID_NhaSX = "2", NgayNhap = new DateTime(2005,3,4), MatHang = "MH7", TinhTrang = false  },
            });

            context.NhaSXes.AddRange(new NhaSX[]
            {
                new NhaSX {ID_NhaSX = "1", TenNhaSX = "Nhà sản xuất 1"},
                new NhaSX {ID_NhaSX = "2", TenNhaSX = "Nhà sản xuất 2"},
                new NhaSX {ID_NhaSX = "3", TenNhaSX = "Nhà sản xuất 3"},
            });
        }
    }
}

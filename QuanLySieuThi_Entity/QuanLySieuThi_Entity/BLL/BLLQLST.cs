using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThi_Entity.DTO;
using QuanLySieuThi_Entity.Entity;

namespace QuanLySieuThi_Entity.BLL
{
    public class BLLQLST
    {
        DALQLST db = new DALQLST();
        private static BLLQLST _Instance;
        public static BLLQLST Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLLQLST();
                return _Instance;
            }
            private set { }
        }

        private BLLQLST()
        {

        }

        public List<CBBItem> GetCBBItemAllNhaSX()
        {
            List<CBBItem> list = new List<CBBItem>();
            list.Add(new CBBItem { Value = "0", Text = "All" });
            foreach (NhaSX x in db.NhaSXes)
            {
                list.Add(new CBBItem
                {
                    Value = x.ID_NhaSX,
                    Text = x.TenNhaSX
                });
            }
            return list;
        }
        public List<CBBItem> GetCBBItemNhaSXByMatHang(string MatHang)
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (SanPham i in db.SanPhams)
            {
                if (i.MatHang.Equals(MatHang))
                {
                    list.Add(new CBBItem { Value = i.ID_NhaSX, Text = i.NhaSX.TenNhaSX });
                }
            }
            return list;
        }

        public List<SanPham_View> SearchSanPham(string ID_NhaSX, string txt)
        {
            List<SanPham_View> list = new List<SanPham_View>();
            if (ID_NhaSX == "0")
            {
                var l1 = from p in db.SanPhams
                         where (p.TenSP.Contains(txt))
                         select p;
                foreach (SanPham i in l1)
                {
                    list.Add(new SanPham_View
                    {
                        MaSP = i.MaSP,
                        TenSP = i.TenSP,
                        MatHang = i.MatHang,
                        NgayNhap = i.NgayNhap,
                        TinhTrang = i.TinhTrang,
                        TenNhaSX = i.NhaSX.TenNhaSX
                    });
                }
            }
            else
            {
                var l2 = from p in db.SanPhams
                         where (p.ID_NhaSX == ID_NhaSX && p.TenSP.Contains(txt))
                         select p;
                foreach (SanPham i in l2)
                {
                    list.Add(new SanPham_View
                    {
                        MaSP = i.MaSP,
                        TenSP = i.TenSP,
                        MatHang = i.MatHang,
                        NgayNhap = i.NgayNhap,
                        TinhTrang = i.TinhTrang,
                        TenNhaSX = i.NhaSX.TenNhaSX
                    });
                }
            }
            return list;
        }

        public void DeleteSanPham(List<String> ListMaSP)
        {
            foreach (string i in ListMaSP)
            {
                SanPham s = db.SanPhams.Find(i);
                db.SanPhams.Remove(s);
                db.SaveChanges();
            }
        }

        public List<SanPham_View> SortSanPham(string ID_NhaSX, string txt, string sortCategory)
        {
            List<SanPham_View> data = new List<SanPham_View>();
            List<SanPham_View> list = SearchSanPham(ID_NhaSX, txt);
            if (sortCategory == "Tên sản phẩm")
            {
                data = list.OrderBy(o => o.TenSP).ToList();
            }
            else if (sortCategory == "Ngày nhập")
            {
                data = list.OrderBy(o => o.NgayNhap).ToList();
            }
            else if (sortCategory == "Tên nhà SX")
            {
                data = list.OrderBy(o => o.TenNhaSX).ToList();
            }
            return data;
        }

        public SanPham GetSPByMaSP(string MaSP)
        {
            return db.SanPhams.Find(MaSP);
        }

        public bool isUpdate(string MaSP)
        {
            if (GetSPByMaSP(MaSP) == null) return false;
            return true;
        }
        public NhaSX GetNhaSXByID(string ID_NhaSX)
        {
            return db.NhaSXes.Find(ID_NhaSX);
        }

        public List<NhaSX> GetNhaSXByMatHang(string s)
        {
            List<NhaSX> list = new List<NhaSX>();
            foreach (SanPham i in db.SanPhams)
            {
                if (i.MatHang == s)
                    list.Add(GetNhaSXByID(i.ID_NhaSX));
            }
            return list;
        }
        public void ExecuteAddUpdate(SanPham s)
        {
            if (isUpdate(s.MaSP))
            {
                SanPham i = db.SanPhams.Find(s.MaSP);
                i.MaSP = s.MaSP;
                i.TenSP = s.TenSP;
                i.ID_NhaSX = s.ID_NhaSX;
                i.NgayNhap = s.NgayNhap;
                i.MatHang = s.MatHang;
                i.TinhTrang = s.TinhTrang;
            }
            else
            {
                db.SanPhams.Add(s);
            }
            db.SaveChanges();
        }
        public List<string> GetAllMatHang()
        {
            List<string> list = new List<string>();
            foreach (SanPham i in db.SanPhams)
            {
                foreach(string s in list)
                {
                    if (i.MatHang.Equals(s))
                        break;
                }
                list.Add(i.MatHang);
            }
            return list;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSP.DTO;

namespace  QLSP
{
    public class BLLQLSP
    {
        QLSP db = new QLSP();
        private static BLLQLSP _Instance;
        public static BLLQLSP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLQLSP();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLQLSP()
        {

        }
        public List<CBBItem> GetCBB_TinhTP()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (Tinh i in db.Tinhs.ToList())
            {
                data.Add(new CBBItem
                {
                    Value = i.MaTinh,
                    Text = i.NameTinh
                });
            }
            return data.Distinct().ToList();
        }
        public List<CBBItem> GetCBB_NhaCungCap()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (NCC i in db.NCCs.ToList())
            {
                data.Add(new CBBItem
                {
                    SpecialValue = i.MaNCC,
                    Text = i.NameNCC
                });
            }
            return data.Distinct().ToList();
     
        }
        public List<SanPham> GetAllSP (string txt = "")
        {
            return db.SanPhams.Where(p => p.NameSP.Contains(txt)).ToList();
        }
        public SanPham GetSPByMaSP (string MaSP)
        {
            return db.SanPhams.Where(p => p.MaSP == MaSP).FirstOrDefault();  
        }
        public List<SanPham_View> GetSanPham_Views(string txt, string v1 ,string v2)
        {
            List<SanPham_View> data = new List<SanPham_View>();
            if(v1 == "All") {
                v1 = "";
                 
             }
            if(v2 == "All") 
            {
                v2 = "";
             } 
            foreach(SanPham i in GetAllSP(txt))
            {
                if (i.NCC.Tinh.NameTinh.Contains(v1) && i.NCC.NameNCC.Contains(v2))
                {
                    data.Add(new SanPham_View
                    {
                        MaSP = i.MaSP,
                        NameSP = i.NameSP,
                        Gia = i.Gia,
                        NgayNhap = i.NgayNhap,
                        NameNCC = i.NCC.NameNCC,
                        NameTinh = i.NCC.Tinh.NameTinh,


                    });
                }
            }
          
            return data;

        }
        public bool CheckAddUpdate(string MaSP)
        {
            foreach(SanPham i in db.SanPhams)
            {
                if (i.MaSP == MaSP)
                {
                    return false;
                }
            }
            return true;
        }
        public void ExcuteDB(string MaSanP, SanPham s)
        {
            if (CheckAddUpdate(s.MaSP))
            {
                db.SanPhams.Add(s);
                db.SaveChanges();
            }
            else
            {
                var x = db.SanPhams.Where(p => p.MaSP == MaSanP).FirstOrDefault();
                x.MaSP = s.MaSP;
                x.NameSP = s.NameSP;
                x.NgayNhap = s.NgayNhap;
                x.Gia = s.Gia;  
                x.SoLuong = s.SoLuong;
                x.MaNCC = s.MaNCC;
                //x.NCC.NameNCC = s.NCC.NameNCC;
                //x.NCC.Tinh.NameTinh = s.NCC.Tinh.NameTinh;
                db.SaveChanges();


            }

        }
        public List<CBBItem> GetCBBNCC_ByCBBTinh(string tenTinh) 
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach(NCC i in db.NCCs.Distinct().ToList()) {
                if (i.Tinh.NameTinh == tenTinh)
                {
                    data.Add(new CBBItem
                    {
                        SpecialValue = i.MaNCC,
                        Text =i.NameNCC
                    });
                }

                    
                } 
            return data;
            } 
        public void DeleteSP(string MaSP)
        {
            var x = db.SanPhams.Find(MaSP);
            db.SanPhams.Remove(x);
            db.SaveChanges();
        }
        public List<SanPham_View> Sort(string txt, string v1 , string v2 , int SortIndex)
        {
            List<SanPham> data = new List<SanPham>();
            if (SortIndex == 0)
            {
                var x = db.SanPhams.Where(p => p.NameSP.Contains(txt))
                    .OrderBy(p => p.NameSP);
                data = x.ToList();
            }
            if (SortIndex == 1)
            {
                var x = db.SanPhams.Where(p => p.NameSP.Contains(txt))
                    .OrderBy(p => p.Gia);
                data = x.ToList();
            }
            List<SanPham_View> data2 = new List<SanPham_View>();
            if (v1 == "All")
            {
                v1 = "";
            }
            if (v2 == "All")
            {
                v2 = "";
            }
            foreach (SanPham i in data)
            {
                if (i.NCC.Tinh.NameTinh.Contains(v1) && i.NCC.NameNCC.Contains(v2))
                {
                    data2.Add(new SanPham_View
                    {
                        MaSP = i.MaSP,
                        NameSP = i.NameSP,
                        Gia = i.Gia,
                        NgayNhap = i.NgayNhap,
                        NameNCC = i.NCC.NameNCC,
                        NameTinh = i.NCC.Tinh.NameTinh,
                        
                    });
                }
            }
            return data2;

        }


    }
}

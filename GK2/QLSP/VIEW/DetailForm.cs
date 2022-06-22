using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSP.DTO;

namespace QLSP.VIEW
{
    public partial class DetailForm : Form
    {
        public delegate void Mydel(string txt, string v1 ,string v2);
        public Mydel d ;
        string MaSanP = "";
        public DetailForm(string m)
        {
            InitializeComponent();
            MaSanP = m;
            CBB();
            GUI();
       
            
        }
        public void GUI()
        {
            if (MaSanP != "")
            {
                SanPham sp = BLLQLSP.Instance.GetSPByMaSP(MaSanP);
                txtMaSP.Text = sp.MaSP;
                txtMaSP.Enabled  = false; 
                txtTenSP.Text = sp.NameSP;
                txtGiaNhap.Text = sp.Gia.ToString();
                txtSoLuong.Text = sp.SoLuong.ToString();
                dateTimePicker1.Text = sp.NgayNhap.ToString();
                //((CBBItem)cboTinh.SelectedItem).Value = sp.NCC.Tinh.MaTinh;
                cboNCC.Text = sp.NCC.NameNCC;
                cboTinh.Text = sp.NCC.Tinh.NameTinh;
             
            }
        }
        public void CBB()
        {
            cboTinh.Items.AddRange(BLLQLSP.Instance.GetCBB_TinhTP().ToArray());
            cboNCC.Items.AddRange(BLLQLSP.Instance.GetCBB_NhaCungCap().ToArray());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SanPham s = Edit();
            BLLQLSP.Instance.ExcuteDB(MaSanP, s);
            d("", "","");
            this.Close();
        }
        public SanPham Edit()
        {
            SanPham s = new SanPham();
            s.MaSP = txtMaSP.Text;
            s.NameSP = txtTenSP.Text;
            s.Gia = Convert.ToInt32(txtGiaNhap.Text);
            s.NgayNhap = dateTimePicker1.Value;
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.MaNCC = ((CBBItem)cboNCC.SelectedItem).SpecialValue;
          

            return s;

        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNCC.Items.Clear();
            cboNCC.Items.AddRange(BLLQLSP.Instance.GetCBBNCC_ByCBBTinh(cboTinh.Text).ToArray());
            cboNCC.Text = "";
        }
    }
}

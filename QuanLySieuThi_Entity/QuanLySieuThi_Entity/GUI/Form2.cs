using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySieuThi_Entity.BLL;
using QuanLySieuThi_Entity.DTO;

namespace QuanLySieuThi_Entity.GUI
{
    public partial class Form2 : Form
    {
        public delegate void MyDel(string ID_NhaSX, string txt);
        public MyDel d;
        string MaSP;
        public Form2(string MaSP)
        {
            InitializeComponent();
            this.MaSP = MaSP;
            GUI();
        }

        private void GUI()
        {
            cbbMatHang.Items.Clear();
            cbbMatHang.Items.AddRange(BLLQLST.Instance.GetAllMatHang().ToArray());
            if (BLLQLST.Instance.isUpdate(MaSP))
            {
                SanPham s = BLLQLST.Instance.GetSPByMaSP(MaSP);
                tbMaSP.Enabled = false;
                tbMaSP.Text = MaSP;
                tbTenSP.Text = s.TenSP;
                dateTimePicker1.Value = s.NgayNhap;
                cbbMatHang.SelectedItem = s.MatHang;
                cbbNhaSX.SelectedIndex = 0;
                ((CBBItem)cbbNhaSX.SelectedItem).setCBBItem(s.ID_NhaSX, s.NhaSX.TenNhaSX);
                if (s.TinhTrang) rbConHang.Checked = true;
                else rbHetHang.Checked = true;
            }
            if (cbbMatHang.SelectedIndex == -1) cbbMatHang.SelectedIndex = 0;
            cbbNhaSX.Items.Clear();
            cbbNhaSX.Items.AddRange(BLLQLST.Instance.GetCBBItemNhaSXByMatHang(cbbMatHang.SelectedItem.ToString()).ToArray());
        }

        private void cbbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMatHang.SelectedIndex == -1) cbbMatHang.SelectedIndex = 0;
            cbbNhaSX.Items.Clear();
            cbbNhaSX.Items.AddRange(BLLQLST.Instance.GetCBBItemNhaSXByMatHang(cbbMatHang.SelectedItem.ToString()).ToArray());
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private SanPham GetSP()
        {
            SanPham s = new SanPham();
            s.MaSP = tbMaSP.Text;
            s.TenSP = tbTenSP.Text;
            s.MatHang = cbbMatHang.Text;
            s.ID_NhaSX = ((CBBItem)cbbNhaSX.SelectedItem).Value;
            s.TinhTrang = rbConHang.Checked;
            s.NgayNhap = dateTimePicker1.Value.Date;
            return s;
        }
        private void butOK_Click(object sender, EventArgs e)
        {
            SanPham s = GetSP();
            BLLQLST.Instance.ExecuteAddUpdate(s);
            d("0", "");
            this.Close();
        }

    }
}

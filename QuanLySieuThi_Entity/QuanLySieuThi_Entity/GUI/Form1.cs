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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
        }

        private void SetCBB()
        {
            cbbNhaSX.Items.Clear();
            cbbNhaSX.Items.AddRange(BLLQLST.Instance.GetCBBItemAllNhaSX().ToArray());
            cbbSort.Items.Clear();
            cbbSort.Items.Add("Tên sản phẩm");
            cbbSort.Items.Add("Ngày nhập");
            cbbSort.Items.Add("Tên nhà SX");
        }
        
        public void ShowDGV(string ID_NhaSX="0", string txt="")
        {
            dataGridView1.DataSource = BLLQLST.Instance.SearchSanPham(ID_NhaSX, txt);
        }

        private void butShow_Click(object sender, EventArgs e)
        {
            if (cbbNhaSX.SelectedIndex > 0)
            {
                ShowDGV(((CBBItem)cbbNhaSX.SelectedItem).Value, "");
            }
            else ShowDGV();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (cbbNhaSX.SelectedIndex == -1) cbbNhaSX.SelectedIndex = 0;
            ShowDGV(((CBBItem)cbbNhaSX.SelectedItem).Value, tbSearch.Text);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    list.Add(row.Cells["MaSP"].Value.ToString());
                }
                BLLQLST.Instance.DeleteSanPham(list);
            }
            ShowDGV();
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex > 0)
            {
                if (cbbNhaSX.SelectedIndex == -1) cbbNhaSX.SelectedIndex = 0;
                string ID_NhaSX = ((CBBItem)cbbNhaSX.SelectedItem).Value;
                string txt = tbSearch.Text;
                string sortCategory = cbbSort.SelectedItem.ToString();
                dataGridView1.DataSource = BLLQLST.Instance.SortSanPham(ID_NhaSX, txt, cbbSort.SelectedItem.ToString());
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.d = new Form2.MyDel(ShowDGV);
            f.Show();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string MaSP = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();
                Form2 f = new Form2(MaSP);
                f.d = new Form2.MyDel(ShowDGV);
                f.Show();
            }
        }
    }
}

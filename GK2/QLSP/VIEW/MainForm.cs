using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSP.VIEW
{
    public partial class MainForm : Form
    {
        QLSP db = new QLSP();
        public MainForm()
        {
            InitializeComponent();
            GUI();
            ShowSP("", "" ,""); 
            cboTinh.SelectedIndex = 0;
            dgvSP.Rows[0].Visible = false;
          
        }
        public void GUI()
        {
            cboTinh.Items.Add("All");
            cboNCC.Items.Add("All");
            cboTinh.Items.AddRange(BLLQLSP.Instance.GetCBB_TinhTP().ToArray());
            cboNCC.Items.AddRange(BLLQLSP.Instance.GetCBB_NhaCungCap().ToArray());

            cboSort.Items.Add("Ten San Pham");
            cboSort.Items.Add("Gia nhap");
        }
        private void ShowSP (string txt , string v1, string v2)
        {
            //dgvSP.Columns.Clear();
            //DataGridViewColumn colSTT = new DataGridViewColumn(new DataGridViewTextBoxCell());
            //colSTT.Name = "STT";
            //colSTT.HeaderText = "STT";
            //dgvSP.Columns.Insert(7, colSTT);
            //for (int i = 0; i < dgvSP.Rows.Count; i++)
            //{

            //    dgvSP.Rows[i].Cells[1].Value = i + 1;
            //}
            dgvSP.DataSource = BLLQLSP.Instance.GetSanPham_Views(txt,v1,v2);
            dgvSP.Columns[0].Visible = false;
        } 

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
            ShowSP(txtSearch.Text , cboTinh.SelectedItem.ToString() ,cboNCC.SelectedItem.ToString());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm("");
            f.d = new DetailForm.Mydel(ShowSP);
            f.Show();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvSP.SelectedRows.Count == 1)
            {
                string MaSP = dgvSP.SelectedRows[0].Cells["MaSP"].Value.ToString();
                DetailForm f1 = new DetailForm(MaSP);
                f1.d = new DetailForm.Mydel(ShowSP);
                f1.Show();
            }
            
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            dgvSP.DataSource = BLLQLSP.Instance.Sort(txtSearch.Text, cboTinh.SelectedItem.ToString(), cboNCC.SelectedItem.ToString(), cboSort.SelectedIndex);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(dgvSP.SelectedRows.Count != -1)
            {
                string MaSanPham = "";
                foreach (DataGridViewRow i in dgvSP.SelectedRows)
                {
                    MaSanPham = i.Cells["MaSP"].Value.ToString();
                }
                BLLQLSP.Instance.DeleteSP(MaSanPham);
               
            }
            ShowSP(txtSearch.Text, cboTinh.SelectedItem.ToString(),cboNCC.SelectedItem.ToString());

        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSP(txtSearch.Text, cboTinh.SelectedItem.ToString(), cboNCC.SelectedItem.ToString());
        }

        private void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTinh.Text == "All")
            {
                cboNCC.Items.Clear();
                cboNCC.Items.Add("All");
                cboNCC.Items.AddRange(BLLQLSP.Instance.GetCBB_NhaCungCap().ToArray());
                cboNCC.SelectedIndex = 0;
            }
            else
            {
                cboNCC.Items.Clear();
                cboNCC.Items.Add("All");
                cboNCC.Items.AddRange(BLLQLSP.Instance.GetCBBNCC_ByCBBTinh(cboTinh.Text).ToArray());
                cboNCC.SelectedIndex = 0;
            }
            ShowSP(txtSearch.Text, cboTinh.SelectedItem.ToString(), cboNCC.SelectedItem.ToString());
        }
    }
}

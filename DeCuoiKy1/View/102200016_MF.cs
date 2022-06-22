using DeCuoiKy1.BLL;
using DeCuoiKy1.DTO;
using DeCuoiKy1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCuoiKy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            Show();
        }
        public void SetCBB()
        {
            cbbProvince.Items.Add(new CBBProvince { Value = "", Text = "All"});
            cbbSupplier.Items.Add(new CBBSupplier { Value = 0, Text = "All"});
            cbbProvince.Items.AddRange(QLSP_BLL.Instance.GetCBBProvince().ToArray());
            cbbSupplier.Items.AddRange(QLSP_BLL.Instance.GetCBBSupplier().ToArray());
            cbbProvince.SelectedIndex = 0;
        }
        public void Show()
        {
            string ProvinceCode = ((CBBProvince)cbbProvince.SelectedItem).Value;
            int Supplier_ID = ((CBBSupplier)cbbSupplier.SelectedItem).Value;
            string txtName = txtSearch.Text;
            string typeSort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = QLSP_BLL.Instance.GetDataTableProduct(QLSP_BLL.Instance.GetAllProduct(ProvinceCode, Supplier_ID, txtName, typeSort));
            dataGridView1.Columns["Mã sản phẩm"].Visible = false;
        }

        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProvince.SelectedIndex != 0)
            {
                cbbSupplier.Items.Clear();
                cbbSupplier.Items.Add(new CBBSupplier { Value = 0, Text = "All" });
                cbbSupplier.Items.AddRange(QLSP_BLL.Instance.GetCBBSupplierByProvince(((CBBProvince)cbbProvince.SelectedItem).Value).ToArray());
                cbbSupplier.SelectedIndex = 0;
            }
            else
            {
                if (cbbSupplier.SelectedItem == null)
                {
                    cbbSupplier.SelectedIndex = 0;
                }
            }
            Show();
        }

        private void cbbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSort.SelectedItem == null)
            {
                cbbSort.SelectedIndex = 0;
            }
            Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void cbbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm("");
            f.d = new DetailForm.MyDel(Show);
            f.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ProductCode = dataGridView1.SelectedRows[0].Cells["Mã sản phẩm"].Value.ToString();
                DetailForm f = new DetailForm(ProductCode);
                f.d = new DetailForm.MyDel(Show);
                f.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        string ProductCode = row.Cells["Mã sản phẩm"].ToString();
                        QLSP_BLL.Instance.Delete(ProductCode);
                    }
                }
                Show();
            }
        }
    }
}

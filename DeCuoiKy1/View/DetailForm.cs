using DeCuoiKy1.BLL;
using DeCuoiKy1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCuoiKy1.View
{
    public partial class DetailForm : Form
    {
        public delegate void MyDel();
        public MyDel d;
        public string Code = "";
        public DetailForm(string ProductCode)
        {
            Code = ProductCode;
            InitializeComponent();
            SetCBB();
            GUI(ProductCode);

        }
        public void SetCBB()
        {
            cbbProvince.Items.AddRange(QLSP_BLL.Instance.GetCBBProvince().ToArray());
            cbbSupplier.Items.AddRange(QLSP_BLL.Instance.GetCBBSupplier().ToArray());
        }

        private void cbbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSupplier.Items.Clear();
            cbbSupplier.Items.AddRange(QLSP_BLL.Instance.GetCBBSupplierByProvince(((CBBProvince)cbbProvince.SelectedItem).Value).ToArray());
            cbbSupplier.Text = "";
        }
        public void GUI(string ProductCode)
        {
            if (ProductCode != "")
            {
                txtCode.Text = QLSP_BLL.Instance.GetProductByProductCode(ProductCode).ProductCode;
                txtCode.Enabled = false;
                txtName.Text = QLSP_BLL.Instance.GetProductByProductCode(ProductCode).ProductName;
                txtPrice.Text = QLSP_BLL.Instance.GetProductByProductCode(ProductCode).Price.ToString();
                dateImport.Value = QLSP_BLL.Instance.GetProductByProductCode(ProductCode).DateImport;
                foreach (CBBProvince i in cbbProvince.Items)
                {
                    if (i.Value == QLSP_BLL.Instance.GetProductByProductCode(ProductCode).Supplier.ProvinceCode)
                    {
                        cbbProvince.SelectedItem = i;
                    }
                }
                foreach (CBBSupplier i in cbbSupplier.Items)
                {
                    if (i.Value == QLSP_BLL.Instance.GetProductByProductCode(ProductCode).Supplier_ID)
                    {
                        cbbSupplier.SelectedItem = i;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductCode = txtCode.Text,
                ProductName = txtName.Text,
                Price = (float)Convert.ToDouble(txtPrice.Text),
                DateImport = Convert.ToDateTime(dateImport.Value),
                Supplier_ID = ((CBBSupplier)cbbSupplier.SelectedItem).Value,
                Supplier = new Supplier { ProvinceCode = ((CBBProvince)cbbProvince.SelectedItem).Value }
            };
            QLSP_BLL.Instance.ExecuteDB(product);
            d();
            this.Close();
        }
    }
}

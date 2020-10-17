using System;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicLayer;
using System.Collections.Generic;

namespace Presentation
{
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        private void btnProductSelect_Click(object sender, EventArgs e)
        {
            FrmProductList frmProductList = new FrmProductList(TypeAction.Select);
            if (frmProductList.ShowDialog() == DialogResult.OK)
            {
                txtId.Text = frmProductList.productSelected.Id.ToString();
                txtProductDescription.Text = frmProductList.productSelected.Description;
                txtQtdeCurrent.Text = frmProductList.productSelected.CurrentQuantity.ToString();
                txtUnitType.Text = frmProductList.productSelected.UnitType.Description;
                txtPrice.Text = frmProductList.productSelected.SalePrice.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductDescription.Text))
            {
                MessageBox.Show("Você precisa selecionar um produto!");
            }
            else if (string.IsNullOrWhiteSpace(txtQuantity.Text)){
                MessageBox.Show("Você precisa informar a quantidade!");
            }
            else if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(txtQtdeCurrent.Text))
            {
                MessageBox.Show("Quantidade indisponível no estoque!");
            }
            else
            {
                string total = (Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();
                dgvItems.Rows.Add(
                    txtId.Text, 
                    txtProductDescription.Text, 
                    txtUnitType.Text, 
                    txtPrice.Text, 
                    txtQuantity.Text, 
                    total);


                
                txtSubTotalSale.Text = (Convert.ToDouble(txtSubTotalSale.Text) + Convert.ToDouble(total)).ToString();

                txtId.Text = "";
                txtProductDescription.Text = "";
                txtQtdeCurrent.Text = "";
                txtUnitType.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(txtSubTotalSale.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);

                txtTotalSale.Text = (total - discount).ToString();
            }
            catch { }
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(txtTotalSale.Text);
                double payment = Convert.ToDouble(txtPayment.Text);

                txtChange.Text = (payment - total).ToString();
            }
            catch { }
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.User = new User();
            sale.User.Id = Properties.Settings.Default.userId;
            sale.Total = Convert.ToDouble(txtTotalSale.Text);
            sale.Discount = Convert.ToDouble(txtDiscount.Text);
            sale.Products = new List<Product>();

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(row.Cells["id_product"].Value);
                product.Quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                product.SalePrice = Convert.ToDouble(row.Cells["unit_price"].Value);

                sale.Products.Add(product);
            }

            SaleBusiness saleBusiness = new SaleBusiness();
            int idSale = saleBusiness.Create(sale);

            MessageBox.Show("Venda Código " + idSale + " registrada com sucesso!");
        }
    }
}

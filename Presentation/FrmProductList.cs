using System;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicLayer;


namespace Presentation
{
    public partial class FrmProductList : Form
    {
        public Product productSelected = null;


        public FrmProductList(TypeAction typeAction)
        {
            InitializeComponent();

            if(typeAction == TypeAction.Select)
            {
                btnEdit.Visible = false;
                btnNew.Visible = false;
                btnSelect.Visible = true;
            }

            if(typeAction == TypeAction.Search)
            {
                btnEdit.Visible = true;
                btnNew.Visible = true;
                btnSelect.Visible = false;
            }

            LoadProducts();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct(TypeAction.Create, null);
            frmProduct.ShowDialog();
        }

        private void LoadProducts()
        {
            ProductBusiness productBusiness = new ProductBusiness();       
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productBusiness.Load();
            dgvProducts.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para editar");
            }
            else
            {
                Product product = new Product();
                int row = dgvProducts.CurrentRow.Index;

                product.Id = Convert.ToInt32(dgvProducts["id", row].Value);
                product.Barcode = dgvProducts["barcode", row].Value.ToString();
                product.Description = dgvProducts["product_description", row].Value.ToString();
                product.UnitType = new UnitType();
                product.UnitType.Id = Convert.ToInt32(dgvProducts["unit_type", row].Value);
                product.MinimumQuantity = Convert.ToInt32(dgvProducts["minimum_quantity", row].Value);
                product.MaximumQuantity = Convert.ToInt32(dgvProducts["maximum_quantity", row].Value);
                product.CurrentQuantity = Convert.ToInt32(dgvProducts["current_quantity", row].Value);
                product.UnitCost = Convert.ToDouble(dgvProducts["unit_cost", row].Value);
                product.PercentageProfit = Convert.ToDouble(dgvProducts["percentage_profit", row].Value);
                product.SalePrice = Convert.ToDouble(dgvProducts["sale_price", row].Value);
                product.Active = Convert.ToBoolean(dgvProducts["active", row].Value);

                FrmProduct frmProduct = new FrmProduct(TypeAction.Update, product);
                DialogResult result = frmProduct.ShowDialog();
                if (result == DialogResult.OK)
                    LoadProducts();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Você precisa clicar no produto para selecionar!");
            }
            else
            {
                int row = dgvProducts.CurrentRow.Index;

                productSelected = new Product();
                productSelected.Id = Convert.ToInt32(dgvProducts["id", row].Value);
                productSelected.Description = dgvProducts["product_description", row].Value.ToString();
                productSelected.CurrentQuantity = Convert.ToInt32(dgvProducts["current_quantity", row].Value);
                productSelected.UnitType = new UnitType();
                productSelected.UnitType.Id = Convert.ToInt32(dgvProducts["unit_type", row].Value);
                productSelected.UnitType.Description = dgvProducts["unit_description", row].Value.ToString();
                productSelected.SalePrice = Convert.ToDouble(dgvProducts["sale_price", row].Value);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

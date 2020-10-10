using System;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicLayer;

namespace Presentation
{
    public partial class FrmProduct : Form
    {
        private TypeAction typeAction;
        private Product productSelected;

        public FrmProduct(TypeAction typeAction, Product product)
        {
            InitializeComponent();

            this.typeAction = typeAction;
            this.productSelected = product;
            LoadFormData();
        }

        private void LoadFormData()
        {
            LoadUnitType();

            switch (this.typeAction)
            {
                case TypeAction.Create:
                    lblFormTitle.Text = "Cadastrar Produto";
                    ckbActive.Checked = true;
                    ckbActive.Enabled = false;
                    break;
                case TypeAction.Update:
                    lblFormTitle.Text = "Atualizar Produto";
                    LoadProductData(this.productSelected);
                    break;             
            }
        }

        private bool FieldsIsValid()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtBarCode.Text))
            {
                errorProvider.SetError(txtBarCode, "Digite o código de barras!");
                errorProvider.SetIconPadding(txtBarCode, -20);
                txtBarCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Digite a descrição do produto!");
                errorProvider.SetIconPadding(txtDescription, -20);
                txtDescription.Focus();
                return false;
            }

            if (cbxUnitType.SelectedIndex < 0)
            {
                errorProvider.SetError(cbxUnitType, "Escolha uma unidade de medida!");
                errorProvider.SetIconPadding(cbxUnitType, -20);
                cbxUnitType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                errorProvider.SetError(txtUnitCost, "Digite o preço unitário do produto!");
                errorProvider.SetIconPadding(txtUnitCost, -20);
                txtUnitCost.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPercentageProfit.Text))
            {
                errorProvider.SetError(txtPercentageProfit, "Digite o percentual do lucro do produto!");
                errorProvider.SetIconPadding(txtPercentageProfit, -20);
                txtPercentageProfit.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSalePrice.Text))
            {
                errorProvider.SetError(txtSalePrice, "Digite o preço de venda do produto!");
                errorProvider.SetIconPadding(txtSalePrice, -20);
                txtSalePrice.Focus();
                return false;
            }

            return true;
        }

        private void Create(Product product)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            int productId = productBusiness.Create(product);

            MessageBox.Show($"Produto ID {productId} cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Update(Product product)
        {
            ProductBusiness productBusiness = new ProductBusiness();
            int productId = productBusiness.Update(product);

            MessageBox.Show($"Produto ID {productId} atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FieldsIsValid())
                {
                    Product product = new Product();
                    product.Barcode = txtBarCode.Text.Trim();
                    product.Description = txtDescription.Text.Trim();
                    product.MinimumQuantity = Convert.ToInt32(nudMinimumQuantity.Value);
                    product.MaximumQuantity = Convert.ToInt32(nudMaximumQuantity.Value);
                    product.CurrentQuantity = Convert.ToInt32(nudCurrentQuantity.Value);
                    product.UnitType = new UnitType();
                    product.UnitType.Id = Convert.ToInt32(cbxUnitType.SelectedValue);
                    product.UnitCost = Convert.ToDouble(txtUnitCost.Text);
                    product.PercentageProfit = Convert.ToDouble(txtUnitCost.Text);
                    product.SalePrice = Convert.ToDouble(txtSalePrice.Text);

                    switch (this.typeAction)
                    {
                        case TypeAction.Create:
                            Create(product);
                            break;
                        case TypeAction.Update:
                            product.Id = this.productSelected.Id;
                            Update(product);
                            break;
                    }
                }
            }catch(Exception error)
            {
                MessageBox.Show("Erro ao carregar os dados. Detalhes: " + error.Message);
            }
        }

        private void LoadUnitType()
        {
            ProductBusiness productBusiness = new ProductBusiness();

            cbxUnitType.DataSource = null;
            cbxUnitType.Items.Clear();

            cbxUnitType.DataSource = productBusiness.LoadUnitType();
            cbxUnitType.ValueMember = "id";
            cbxUnitType.DisplayMember = "description";
        }

        private void LoadProductData(Product product)
        {
            txtBarCode.Text = product.Barcode;
            txtDescription.Text = product.Description;
            nudMinimumQuantity.Value = product.MinimumQuantity;
            nudMaximumQuantity.Value = product.MaximumQuantity;
            nudCurrentQuantity.Value = product.CurrentQuantity;
            cbxUnitType.SelectedValue = product.UnitType.Id;
            txtUnitCost.Text = product.UnitCost.ToString();
            txtPercentageProfit.Text = product.PercentageProfit.ToString();
            txtSalePrice.Text = product.SalePrice.ToString();

            if (product.Active)
                ckbActive.Checked = true;
            else
                ckbActive.Checked = false;
        }
    }
}

namespace Presentation
{
    partial class FrmProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barcode,
            this.product_description,
            this.unit_type,
            this.unit_description,
            this.minimum_quantity,
            this.maximum_quantity,
            this.current_quantity,
            this.unit_cost,
            this.percentage_profit,
            this.sale_price,
            this.active});
            this.dgvProducts.Location = new System.Drawing.Point(12, 100);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1286, 672);
            this.dgvProducts.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(624, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 67);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar Produto";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(457, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 67);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Novo Produto";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Código de Barras";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 125;
            // 
            // product_description
            // 
            this.product_description.DataPropertyName = "product_description";
            this.product_description.HeaderText = "Produto";
            this.product_description.MinimumWidth = 6;
            this.product_description.Name = "product_description";
            this.product_description.ReadOnly = true;
            this.product_description.Width = 125;
            // 
            // unit_type
            // 
            this.unit_type.DataPropertyName = "unit_type";
            this.unit_type.HeaderText = "ID Unidade de Medida";
            this.unit_type.MinimumWidth = 6;
            this.unit_type.Name = "unit_type";
            this.unit_type.ReadOnly = true;
            this.unit_type.Visible = false;
            this.unit_type.Width = 125;
            // 
            // unit_description
            // 
            this.unit_description.DataPropertyName = "unit_description";
            this.unit_description.HeaderText = "Unidade de Medida";
            this.unit_description.MinimumWidth = 6;
            this.unit_description.Name = "unit_description";
            this.unit_description.ReadOnly = true;
            this.unit_description.Width = 125;
            // 
            // minimum_quantity
            // 
            this.minimum_quantity.DataPropertyName = "minimum_quantity";
            this.minimum_quantity.HeaderText = "Qtde. Mínima";
            this.minimum_quantity.MinimumWidth = 6;
            this.minimum_quantity.Name = "minimum_quantity";
            this.minimum_quantity.ReadOnly = true;
            this.minimum_quantity.Width = 125;
            // 
            // maximum_quantity
            // 
            this.maximum_quantity.DataPropertyName = "maximum_quantity";
            this.maximum_quantity.HeaderText = "Qtde. Máxima";
            this.maximum_quantity.MinimumWidth = 6;
            this.maximum_quantity.Name = "maximum_quantity";
            this.maximum_quantity.ReadOnly = true;
            this.maximum_quantity.Width = 125;
            // 
            // current_quantity
            // 
            this.current_quantity.DataPropertyName = "current_quantity";
            this.current_quantity.HeaderText = "Qtde. Atual";
            this.current_quantity.MinimumWidth = 6;
            this.current_quantity.Name = "current_quantity";
            this.current_quantity.ReadOnly = true;
            this.current_quantity.Width = 125;
            // 
            // unit_cost
            // 
            this.unit_cost.DataPropertyName = "unit_cost";
            this.unit_cost.HeaderText = "R$ Unidade";
            this.unit_cost.MinimumWidth = 6;
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.ReadOnly = true;
            this.unit_cost.Width = 125;
            // 
            // percentage_profit
            // 
            this.percentage_profit.DataPropertyName = "percentage_profit";
            this.percentage_profit.HeaderText = "% Lucro";
            this.percentage_profit.MinimumWidth = 6;
            this.percentage_profit.Name = "percentage_profit";
            this.percentage_profit.ReadOnly = true;
            this.percentage_profit.Width = 125;
            // 
            // sale_price
            // 
            this.sale_price.DataPropertyName = "sale_price";
            this.sale_price.HeaderText = "R$ Venda";
            this.sale_price.MinimumWidth = 6;
            this.sale_price.Name = "sale_price";
            this.sale_price.ReadOnly = true;
            this.sale_price.Width = 125;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "Ativo";
            this.active.MinimumWidth = 6;
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.Width = 125;
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 784);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvProducts);
            this.Name = "FrmProductList";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimum_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximum_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
    }
}
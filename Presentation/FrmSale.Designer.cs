namespace Presentation
{
    partial class FrmSale
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
            this.btnProductSelect = new System.Windows.Forms.Button();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdeCurrent = new System.Windows.Forms.TextBox();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubTotalSale = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductSelect
            // 
            this.btnProductSelect.Location = new System.Drawing.Point(991, 148);
            this.btnProductSelect.Name = "btnProductSelect";
            this.btnProductSelect.Size = new System.Drawing.Size(145, 38);
            this.btnProductSelect.TabIndex = 0;
            this.btnProductSelect.Text = "Selecionar Produto";
            this.btnProductSelect.UseVisualStyleBackColor = true;
            this.btnProductSelect.Click += new System.EventHandler(this.btnProductSelect_Click);
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.Location = new System.Drawing.Point(176, 148);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ReadOnly = true;
            this.txtProductDescription.Size = new System.Drawing.Size(795, 38);
            this.txtProductDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produto";
            // 
            // txtUnitType
            // 
            this.txtUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitType.Location = new System.Drawing.Point(308, 259);
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.ReadOnly = true;
            this.txtUnitType.Size = new System.Drawing.Size(246, 38);
            this.txtUnitType.TabIndex = 3;
            this.txtUnitType.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unidade de Medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(587, 259);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(258, 38);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(871, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(876, 259);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(260, 38);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtde. Disponível";
            // 
            // txtQtdeCurrent
            // 
            this.txtQtdeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeCurrent.Location = new System.Drawing.Point(28, 259);
            this.txtQtdeCurrent.Name = "txtQtdeCurrent";
            this.txtQtdeCurrent.ReadOnly = true;
            this.txtQtdeCurrent.Size = new System.Drawing.Size(246, 38);
            this.txtQtdeCurrent.TabIndex = 9;
            this.txtQtdeCurrent.Text = " ";
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSale.Location = new System.Drawing.Point(718, 12);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(199, 67);
            this.btnConfirmSale.TabIndex = 11;
            this.btnConfirmSale.Text = "Finalizar Venda";
            this.btnConfirmSale.UseVisualStyleBackColor = true;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(937, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 67);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_product,
            this.description,
            this.unit_description,
            this.unit_price,
            this.quantity,
            this.total});
            this.dgvItems.Location = new System.Drawing.Point(28, 387);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(805, 414);
            this.dgvItems.TabIndex = 13;
            // 
            // id_product
            // 
            this.id_product.HeaderText = "ID";
            this.id_product.MinimumWidth = 6;
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Produto";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // unit_description
            // 
            this.unit_description.HeaderText = "Unidade de Medida";
            this.unit_description.MinimumWidth = 6;
            this.unit_description.Name = "unit_description";
            this.unit_description.ReadOnly = true;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "R$ Unitário";
            this.unit_price.MinimumWidth = 6;
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantidade";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "R$ Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(752, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 38);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(665, 343);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 38);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(873, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor Total";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSale.Location = new System.Drawing.Point(878, 597);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(258, 38);
            this.txtTotalSale.TabIndex = 16;
            this.txtTotalSale.Text = " 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(871, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Valor Pago";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(876, 684);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(258, 38);
            this.txtPayment.TabIndex = 18;
            this.txtPayment.Text = " 0";
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(871, 728);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Troco";
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(876, 763);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(258, 38);
            this.txtChange.TabIndex = 20;
            this.txtChange.Text = " 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(871, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sub Total";
            // 
            // txtSubTotalSale
            // 
            this.txtSubTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotalSale.Location = new System.Drawing.Point(876, 421);
            this.txtSubTotalSale.Name = "txtSubTotalSale";
            this.txtSubTotalSale.ReadOnly = true;
            this.txtSubTotalSale.Size = new System.Drawing.Size(258, 38);
            this.txtSubTotalSale.TabIndex = 22;
            this.txtSubTotalSale.Text = " 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(873, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Desconto";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(878, 507);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(258, 38);
            this.txtDiscount.TabIndex = 24;
            this.txtDiscount.Text = " 0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(28, 148);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(123, 38);
            this.txtId.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 29);
            this.label11.TabIndex = 27;
            this.label11.Text = "Código";
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 811);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubTotalSale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtdeCurrent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnitType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.btnProductSelect);
            this.Name = "FrmSale";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductSelect;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtdeCurrent;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubTotalSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
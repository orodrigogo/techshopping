namespace Presentation
{
    partial class FrmProduct
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
            this.components = new System.ComponentModel.Container();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbxUnitType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPercentageProfit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.ckbActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudMinimumQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudMaximumQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudCurrentQuantity = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 43);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(389, 46);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Cadastro de Produto";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarCode.Location = new System.Drawing.Point(28, 176);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(821, 38);
            this.txtBarCode.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(28, 283);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(821, 38);
            this.txtDescription.TabIndex = 2;
            // 
            // cbxUnitType
            // 
            this.cbxUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnitType.FormattingEnabled = true;
            this.cbxUnitType.Location = new System.Drawing.Point(562, 390);
            this.cbxUnitType.Name = "cbxUnitType";
            this.cbxUnitType.Size = new System.Drawing.Size(287, 44);
            this.cbxUnitType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código de barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(557, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidade de Medida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtde. Mínima:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(207, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qtde. Máxima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(380, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Qtde. Atual:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(25, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Preço Unitário:";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(28, 517);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(205, 38);
            this.txtUnitCost.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(279, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "% Lucro:";
            // 
            // txtPercentageProfit
            // 
            this.txtPercentageProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentageProfit.Location = new System.Drawing.Point(284, 517);
            this.txtPercentageProfit.Name = "txtPercentageProfit";
            this.txtPercentageProfit.Size = new System.Drawing.Size(255, 38);
            this.txtPercentageProfit.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(567, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Preço de Venda:";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(562, 517);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(287, 38);
            this.txtSalePrice.TabIndex = 17;
            // 
            // ckbActive
            // 
            this.ckbActive.AutoSize = true;
            this.ckbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbActive.Location = new System.Drawing.Point(771, 604);
            this.ckbActive.Name = "ckbActive";
            this.ckbActive.Size = new System.Drawing.Size(78, 29);
            this.ckbActive.TabIndex = 19;
            this.ckbActive.Text = "Ativo";
            this.ckbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(539, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 63);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(707, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 63);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudMinimumQuantity
            // 
            this.nudMinimumQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinimumQuantity.Location = new System.Drawing.Point(30, 393);
            this.nudMinimumQuantity.Name = "nudMinimumQuantity";
            this.nudMinimumQuantity.Size = new System.Drawing.Size(136, 41);
            this.nudMinimumQuantity.TabIndex = 22;
            // 
            // nudMaximumQuantity
            // 
            this.nudMaximumQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaximumQuantity.Location = new System.Drawing.Point(212, 391);
            this.nudMaximumQuantity.Name = "nudMaximumQuantity";
            this.nudMaximumQuantity.Size = new System.Drawing.Size(136, 41);
            this.nudMaximumQuantity.TabIndex = 23;
            // 
            // nudCurrentQuantity
            // 
            this.nudCurrentQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCurrentQuantity.Location = new System.Drawing.Point(385, 391);
            this.nudCurrentQuantity.Name = "nudCurrentQuantity";
            this.nudCurrentQuantity.Size = new System.Drawing.Size(136, 41);
            this.nudCurrentQuantity.TabIndex = 24;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 663);
            this.Controls.Add(this.nudCurrentQuantity);
            this.Controls.Add(this.nudMaximumQuantity);
            this.Controls.Add(this.nudMinimumQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ckbActive);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPercentageProfit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxUnitType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "FrmProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbxUnitType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPercentageProfit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.CheckBox ckbActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudMinimumQuantity;
        private System.Windows.Forms.NumericUpDown nudMaximumQuantity;
        private System.Windows.Forms.NumericUpDown nudCurrentQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
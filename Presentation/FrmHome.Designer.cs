namespace Presentation
{
    partial class FrmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btmSaleHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1021, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao Sistema de Estoque e Vendas";
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(38, 186);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(280, 312);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Produtos";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 653);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(158, 17);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "CÓDIGO DO USUÁRIO:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(702, 649);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(144, 17);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "NOME DO USUÁRIO:";
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(405, 185);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(280, 312);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Vendas";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btmSaleHistory
            // 
            this.btmSaleHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSaleHistory.Location = new System.Drawing.Point(728, 185);
            this.btmSaleHistory.Name = "btmSaleHistory";
            this.btmSaleHistory.Size = new System.Drawing.Size(280, 312);
            this.btmSaleHistory.TabIndex = 5;
            this.btmSaleHistory.Text = "Histórico de Vendas";
            this.btmSaleHistory.UseVisualStyleBackColor = true;
            this.btmSaleHistory.Click += new System.EventHandler(this.btmSaleHistory_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 683);
            this.Controls.Add(this.btmSaleHistory);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.label1);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btmSaleHistory;
    }
}
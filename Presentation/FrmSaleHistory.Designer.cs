namespace Presentation
{
    partial class FrmSaleHistory
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAt = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.chbActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_user,
            this.name_user,
            this.id_product,
            this.description_product,
            this.quantity,
            this.date,
            this.hour,
            this.reason,
            this.action});
            this.dgvHistory.Location = new System.Drawing.Point(12, 94);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(1108, 626);
            this.dgvHistory.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id do Histórico";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "Id do Usuário";
            this.id_user.MinimumWidth = 6;
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // name_user
            // 
            this.name_user.DataPropertyName = "name_user";
            this.name_user.HeaderText = "Usuário";
            this.name_user.MinimumWidth = 6;
            this.name_user.Name = "name_user";
            this.name_user.ReadOnly = true;
            // 
            // id_product
            // 
            this.id_product.DataPropertyName = "id_product";
            this.id_product.HeaderText = "Id Produto";
            this.id_product.MinimumWidth = 6;
            this.id_product.Name = "id_product";
            this.id_product.ReadOnly = true;
            // 
            // description_product
            // 
            this.description_product.DataPropertyName = "description_product";
            this.description_product.HeaderText = "Produto";
            this.description_product.MinimumWidth = 6;
            this.description_product.Name = "description_product";
            this.description_product.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Qtd";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Data";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // hour
            // 
            this.hour.DataPropertyName = "hour";
            this.hour.HeaderText = "Hora";
            this.hour.MinimumWidth = 6;
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            // 
            // reason
            // 
            this.reason.DataPropertyName = "reason";
            this.reason.HeaderText = "Motivo";
            this.reason.MinimumWidth = 6;
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            // 
            // action
            // 
            this.action.DataPropertyName = "action";
            this.action.HeaderText = "Ação";
            this.action.MinimumWidth = 6;
            this.action.Name = "action";
            this.action.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 38);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Produto";
            // 
            // dtpAt
            // 
            this.dtpAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAt.Location = new System.Drawing.Point(498, 47);
            this.dtpAt.Name = "dtpAt";
            this.dtpAt.Size = new System.Drawing.Size(191, 38);
            this.dtpAt.TabIndex = 3;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(756, 47);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(191, 38);
            this.dtpTo.TabIndex = 4;
            // 
            // chbActive
            // 
            this.chbActive.AutoSize = true;
            this.chbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbActive.Location = new System.Drawing.Point(970, 44);
            this.chbActive.Name = "chbActive";
            this.chbActive.Size = new System.Drawing.Size(135, 36);
            this.chbActive.TabIndex = 5;
            this.chbActive.Text = "Inativos";
            this.chbActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "até";
            // 
            // FrmSaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 732);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbActive);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpAt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvHistory);
            this.Name = "FrmSaleHistory";
            this.Text = "FrmSaleHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn description_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAt;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.CheckBox chbActive;
        private System.Windows.Forms.Label label2;
    }
}
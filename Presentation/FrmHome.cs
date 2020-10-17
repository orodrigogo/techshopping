using DataTransferObject;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            lblUserId.Text = "CÓDIGO DO USUÁRIO: " + Properties.Settings.Default.userId.ToString();
            lblUserName.Text = "NOME DO USUÁRIO: " + Properties.Settings.Default.userName.ToUpper();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProductList frmProductList = new FrmProductList(TypeAction.Search);
            frmProductList.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmSale frmSale = new FrmSale();
            frmSale.ShowDialog();
        }

        private void btmSaleHistory_Click(object sender, EventArgs e)
        {
            FrmSaleHistory frmSaleHistory = new FrmSaleHistory();
            frmSaleHistory.ShowDialog();
        }
    }
}

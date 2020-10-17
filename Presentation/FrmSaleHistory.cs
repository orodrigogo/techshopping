using System;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Presentation
{
    public partial class FrmSaleHistory : Form
    {
        public FrmSaleHistory()
        {
            InitializeComponent();

            Search();
        }

        private void Search()
        {
            SaleBusiness saleBusiness = new SaleBusiness();
            
           dgvHistory.DataSource = saleBusiness.HistorySearch(txtSearch.Text, dtpAt.Value, dtpTo.Value, chbActive.Checked);
            dgvHistory.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}

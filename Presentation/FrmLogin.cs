using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace Presentation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            txtEmail.Text = "rodrigo@email.com";
            txtPassword.Text = "123";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = FieldsIsValid();

                if (isValid)
                {
                    User user = new User();
                    UserBusiness userBusiness = new UserBusiness();
                    user = userBusiness.Login(txtEmail.Text, txtPassword.Text);
                    
                    Properties.Settings.Default.userId = user.Id;
                    Properties.Settings.Default.userName = user.Name;
                    Properties.Settings.Default.Save();

                    FrmHome frmHome = new FrmHome();
                    frmHome.Show();

                    this.Hide();
                }
            }catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private bool FieldsIsValid()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Digite o E-mail!");
                errorProvider.SetIconPadding(txtEmail, -20);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Digite a Senha");
                errorProvider.SetIconPadding(txtPassword, -20);
                txtEmail.Focus();
                return false;
            }

            return true;
        }
    }
}

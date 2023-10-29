using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emlak.UI.EmlakServiceReference;

namespace Emlak.UI.Forms
{
    public partial class LoginForm : Form
    {
        private Main _main;
        public LoginForm(Main main)
        {
            this._main = main;
            InitializeComponent();
        }
        private EmlakServiceClient client = new EmlakServiceClient();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorMessage.SetError(txtUsername, "Kullanıcı Giriniz!");
                errorMessage.SetError(txtPassword, "Şifre Giriniz!");
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorMessage.SetError(txtUsername, "Kullanıcı Giriniz!");
                errorMessage.SetError(txtPassword, null);
            }
            else if(string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorMessage.SetError(txtPassword, "Şifre Giriniz!");
                errorMessage.SetError(txtUsername, null);
            }
            else
            {
               var user = client.GetUsers(txtUsername.Text, txtPassword.Text);
                if (user!=null )
                {
                    this.Close();
                    _main.toolMenu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı!", "Sisteme Giriş", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}

using OOP_FileWriting_Example.Manager;
using System;
using System.Windows.Forms;

namespace OOP_FileWriting_Example {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            var appUserManager = new AppUserManager();

            string username = txtUserName.Text;
            string password = txtPassword.Text;
            bool isValidUser = appUserManager.CheckCredentials(username, password);

            if (isValidUser == true) {
                var mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            } else {
                MessageBox.Show("Lütfen giriş bilgileriniz kontrol ediniz.");
            }
        }
    }
}

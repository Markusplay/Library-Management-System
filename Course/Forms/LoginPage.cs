using System;
using System.Windows.Forms;
using Course.View;
using Course.Presenter;
namespace Course
{
    public partial class LoginPage : Form, ILogin
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public string UsernameText
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public string PasswordText
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPresenter loginPresenter = new LoginPresenter(this);
            loginPresenter.StartAdminPage();
        }
        private void Form1_Load(object sender, EventArgs e)
        { }
        private void SignInGuest_Click(object sender, EventArgs e)
        {
            GuestPage guestPage = new GuestPage();
            Hide();
            guestPage.Show();
        }
    }
}
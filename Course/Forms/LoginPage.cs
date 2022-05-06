using System;
using System.Windows.Forms;
using Course.View;
using Course.Presenter;
namespace Course
{
    public partial class LoginPage : Form, IGuestLog, IAdminLog
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

        public string AdminLoginText
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GuestLogPresenter guest = new GuestLogPresenter(this);
            guest.StartGuestPage();
        }
        private void Form1_Load(object sender, EventArgs e)
        { }
        private void SignInAdmin_Click(object sender, EventArgs e)
        {
            AdminPresenter admin = new AdminPresenter(this);
            try
            {
                admin.StartAdminPage();

            }
            catch (Exception)
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }
    }
}
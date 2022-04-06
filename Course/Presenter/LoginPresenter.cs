using System;
using Course.Model;
using Course.View;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Course.Presenter
{
    class LoginPresenter
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LibraryData.mdf;Integrated Security=True");
        ILogin loginView;
        private int _checkLogin = 0;
        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }
        public void checkConnection()
        {
            if (connection.State == ConnectionState.Open) //Check if connection to database is already opened
                connection.Close();
            connection.Open();
        }
        public void StartAdminPage()
        {
            checkConnection();
            LoginModel login = new LoginModel();
            login.Username = loginView.UsernameText;
            login.Password = loginView.PasswordText;
            SqlCommand commandLogin = new SqlCommand("SELECT * FROM library_user WHERE Username='" + login.Username + "' AND Password='" + login.Password + "'", connection);
            commandLogin.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandLogin);
            dataAdapter.Fill(dataTable);
            _checkLogin = Convert.ToInt32(dataTable.Rows.Count.ToString());
            if (_checkLogin == 0)
                MessageBox.Show("Username or password is incorrect");
            else
            {
                AdminPage adminPage = new AdminPage();
                AdminPage.ActiveForm.Hide();
                adminPage.Show();
            }
        }
    }
}

using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
namespace Course.Presenter
{
    class AdminPresenter
    {
        IAdminLog adminView;
        public AdminPresenter(IAdminLog view) => adminView = view;
        public void StartAdminPage()
        {
            using (Entities context = new Entities())
            {
                var name = context.Admins.FirstOrDefault(a => a.AdminName == adminView.AdminLoginText);
                var pass = context.Admins.FirstOrDefault(p => p.Password == adminView.PasswordText);
                if (name == null || pass == null || name.Id != pass.Id)
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                else
                {
                    AdminPage adminPage = new AdminPage();
                    Form.ActiveForm.Hide();
                    adminPage.Show();
                }
            }
        }
    }
}

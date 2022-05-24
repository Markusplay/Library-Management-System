using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Linq;
namespace Course.Presenter
{
    class AdminPresenter
    {
        IAdminLog adminView;
        public AdminPresenter(IAdminLog view) => adminView = view;
        // Check the correction of inputed data and start admin`s page
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
                    try
                    {
                        AdminPage adminPage = new AdminPage();
                        Form.ActiveForm.Hide();
                        adminPage.Show();
                    }
                    catch (NullReferenceException) { }
                }
            }
        }
    }
}

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
                var name = context.AdminNames.FirstOrDefault(a => a.Name == adminView.AdminLoginText);
                var pass = context.AdminPasswords.FirstOrDefault(p => p.Password == adminView.PasswordText);
                if (name == null || pass == null || name.AdminId != pass.PasswordId)
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                else
                {
                    try
                    {
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Repeat response");
                    }
                }
            }
        }
    }
}

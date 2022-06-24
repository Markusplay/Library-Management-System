using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Linq;
namespace Course.Presenter
{
    class AdminPresenter:GuestPresenter
    {
        IAdminLog adminView;
        public AdminPresenter(IAdminLog view) => adminView = view;
        // Check the correction of inputed data and start admin`s page
        public bool StartAdminPage()
        {
            using (Entities context = new Entities())
            {
                var name = context.AdminNames.FirstOrDefault(a => a.Name == adminView.AdminLoginText);
                var pass = context.AdminPasswords.FirstOrDefault(p => p.Password == adminView.PasswordText);
                if (name == null || pass == null || name.AdminId != pass.PasswordId)
                {
                    MessageBox.Show("Username or password is incorrect");
                    return false;
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
                return true;
            }
        }
        public void Register()
        {
            try
            {
                using (Entities context = new Entities())
                {
                    Guests newGuest = new Guests() { Username = adminView.AdminLoginText, Password = adminView.PasswordText };
                    var nameExist = context.Guests.Select(i => i.Username).Contains(newGuest.Username);
                    if (nameExist)
                        MessageBox.Show("User is already exists");
                    else
                    {
                        context.Guests.Add(newGuest);
                        context.SaveChanges();
                        MessageBox.Show("User registered");
                    }
                    if (newGuest.Username == null || newGuest.Password == null)
                        MessageBox.Show("Username or password is incorrect");   
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            
        }
    }
}

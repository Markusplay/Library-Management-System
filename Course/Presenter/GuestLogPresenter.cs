using System.Linq;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System;
namespace Course.Presenter
{
    class GuestLogPresenter
    {
        IGuestLog guestLogView;
        public GuestLogPresenter(IGuestLog view) => guestLogView = view;
        public void StartGuestPage()
        {
            using (Entities context = new Entities())
            {
                var name = context.Users.FirstOrDefault(a => a.Username == guestLogView.UsernameText);
                var pass = context.Users.FirstOrDefault(p => p.Password == guestLogView.PasswordText);
                if (name == null || pass == null || name.Id != pass.Id)
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                else
                {
                    try
                    {
                        GuestPage guest = new GuestPage(name.Id);
                        Form.ActiveForm.Hide();
                        guest.Show();
                    }
                    catch (NullReferenceException)
                    { }
                    catch (Exception)
                    { MessageBox.Show("Something went wrong"); }

                }
            }
        }
    }
}

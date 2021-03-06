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
        // Check the correction of inputed data and start guest`s page
        public bool StartGuestPage()
        {
            using (Entities context = new Entities())
            {
                var name = context.Guests.FirstOrDefault(a => a.Username == guestLogView.UsernameText);
                var pass = context.Guests.FirstOrDefault(p => p.Password == guestLogView.PasswordText);
                if (name == null || pass == null || name.Id != pass.Id)
                {
                    MessageBox.Show("Username or password is incorrect");
                    return false;
                }
                else
                {
                    try
                    {
                        GuestPage guest = new GuestPage(name.Id);
                        guest.Show();
                    }
                    catch (Exception) { }
                }
                return true;
            }
        }
    }
}

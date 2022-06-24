using System;
using System.Windows.Forms;
namespace Course
{
    public partial class AdminPage : Form
    {
        public AdminPage() => InitializeComponent();

        private void Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            Hide();
            loginPage.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBooks editBooks = new EditBooks();
            Hide();
            editBooks.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBookPage deleteBook = new DeleteBookPage();
            Hide();
            deleteBook.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookPage addBook = new AddBookPage();
            Hide();
            addBook.Show();
        }
    }
}

using System;
using System.Windows.Forms;
namespace Course
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            addBook addBook = new addBook();
            Hide();
            addBook.Show();
        }

        private void Exit_Click(object sender, EventArgs e) => Application.Exit();
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            Hide();
            loginPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteBook deleteBook = new DeleteBook();
            Hide();
            deleteBook.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditBooks editBooks = new EditBooks();
            Hide();
            editBooks.Show();
        }
    }
}

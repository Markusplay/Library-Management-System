using System;
using System.Windows.Forms;
using Course.Presenter;
using Course.View;
namespace Course
{
    public partial class addBook : Form, IAddBook
    {
        public string TitleText
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }
        public string AuthorText
        {
            get { return txtAuthor.Text; }
            set { txtAuthor.Text = value; }
        }
        public string GenreText
        {
            get { return txtGenre.Text; }
            set { txtGenre.Text = value; }
        }
        public string PriceText 
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
        public string PublicationYearText
        {
            get { return txtYear.Text; }
            set { txtYear.Text = value; }
        }

        public addBook()
        {
            InitializeComponent();
        }
        private void addBook_Load(object sender, EventArgs e){}
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            Hide();
            adminPage.Show();
        }

        private void btnAddToCatalogue_Click(object sender, EventArgs e)
        {
            AddBookPresenter addBookPresenter = new AddBookPresenter(this);
            addBookPresenter.AddBookToCatalog();
        }
    }
}

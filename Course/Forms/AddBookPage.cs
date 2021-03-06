using System;
using System.Windows.Forms;
using Course.Presenter;
using Course.View;
namespace Course
{
    public partial class AddBookPage : Form, IAddBook
    {
        private string _selectedGenre;
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
            get { return _selectedGenre; }
            set { _selectedGenre = value; }
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
        public string NewGenreText
        {
            get { return txtNewGenre.Text; }
            set { txtNewGenre.Text = value; }
        }

        public AddBookPage() => InitializeComponent();

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            Hide();
            adminPage.Show();
        }

        private void comboBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedGenre = comboBoxGenres.SelectedValue.ToString();
        }

        private void btnAddToCatalogue_Click(object sender, EventArgs e)
        {
            AddBookPresenter addBookPresenter = new AddBookPresenter(this);

            if (!addBookPresenter.BookExist(_selectedGenre))
            {
                addBookPresenter.AddBookToCatalog(_selectedGenre);
            }
        }

        private void addBook_Load(object sender, EventArgs e)
        {
            this.genresTableAdapter.Fill(this.catalogDataSet.Genres);
        }

        private void btnAddNewGenre_Click(object sender, EventArgs e)
        {
            AddBookPresenter addBookPresenter = new AddBookPresenter(this);
            if (NewGenreText=="")
            {
                MessageBox.Show("Input genre");
            }
            else
            {
                addBookPresenter.AddNewGenre(NewGenreText);
            }
            
        }
    }
}

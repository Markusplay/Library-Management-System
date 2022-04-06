using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Course.Presenter
{
    class AddBookPresenter
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LibraryData.mdf;Integrated Security=True");
        IAddBook addBookView;
        AddBookModel addBook = new AddBookModel();
        public AddBookPresenter(IAddBook view) {addBookView = view;}
        public void ClearFields()
        {
            addBookView.TitleText = "";
            addBookView.AuthorText = "";
            addBookView.GenreText = "";
            addBookView.PriceText = "";
            addBookView.PublicationYearText = "";
        }
        public void AddBookToCatalog()
        {
            connection.Open();  
            addBook.Title = addBookView.TitleText;
            addBook.Author = addBookView.AuthorText;
            addBook.Genre = addBookView.GenreText;
            addBook.Price = addBookView.PriceText;
            addBook.PublicationYear = addBookView.PublicationYearText;
            bool correct;
            try
            {
                SqlCommand commandAdd = new SqlCommand("if exists(select Title, Author, Genre, Price, PublicationYear" +
                    " from book_catalog" +
                    " where Title = '" + addBook.Title + "' and Author = '" + addBook.Author + "' and Genre = '" + addBook.Genre + "' and Price = " + addBook.Price + " and PublicationYear = " + addBook.PublicationYear + ")" +
                    " begin" +
                    " select id from book_catalog" +
                    " end" +
                    " else" +
                    " begin" +
                    " insert into book_catalog values('" + addBook.Title + "','" + addBook.Author + "','" + addBook.Genre + "'," + addBook.Price + ", " + addBook.PublicationYear + " )" +
                    " end", connection);
                commandAdd.ExecuteNonQuery();
                correct = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
                ClearFields();
                correct = false;
            }
            connection.Close();
            ClearFields();
            if (correct)
                MessageBox.Show("Book added successfully");
        }
    }
}

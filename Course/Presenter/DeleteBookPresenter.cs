using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Course.Presenter
{
    class DeleteBookPresenter : GuestPresenter
    {
        DeleteBookModel deleteBook = new DeleteBookModel();
        IDeleteBook deleteBookView;
        SqlConnection connection = new SqlConnection(@"Data Source=САША-ПК\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        public DeleteBookPresenter(IDeleteBook view) : base(view)
        {
            deleteBookView = view;
        }
        public void DeleteBook(DataGridView dataGridView)
        {
            bool bookIsDeleted = true;
            deleteBook.Title = deleteBookView.TitleText;
            deleteBook.Author = deleteBookView.AuthorText;
            deleteBook.Genre = deleteBookView.GenreText;
            deleteBook.Price = deleteBookView.PriceText;
            deleteBook.PublicationYear = deleteBookView.PublicationYearText;
            connection.Open();
            try
            {
                int CurrentRowIndex = dataGridView.CurrentCell.RowIndex;
                dataGridView.Rows.RemoveAt(CurrentRowIndex);
                SqlCommand deleteCommand = new SqlCommand("DELETE book_catalog  WHERE Title = '" + deleteBook.Title + "' AND Author = '" + deleteBook.Author + "' AND Genre = '" + deleteBook.Genre + "' AND Price = '" + deleteBook.Price + "' AND PublicationYear = '" + deleteBook.PublicationYear + "'", connection);
                deleteCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            if (bookIsDeleted)
                MessageBox.Show("Book deleted successfully");
            connection.Close();
        }

    }
}

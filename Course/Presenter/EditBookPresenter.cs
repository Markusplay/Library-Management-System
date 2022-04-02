using System;
using Course.Model;
using Course.View;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Course.Presenter
{
    class EditBookPresenter : GuestPresenter
    {
        IEditBook editBookView;
        EditBookModel editBookModel = new EditBookModel();
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Саша\source\repos\Course\Course\LibraryData.mdf;Integrated Security=True");
        public EditBookPresenter(IEditBook view) : base(view)
        {
            editBookView = view;
            editBookModel.Title = editBookView.TitleText;
            editBookModel.Author = editBookView.AuthorText;
            editBookModel.Genre = editBookView.GenreText;
            editBookModel.Price = editBookView.PriceText;
            editBookModel.PublicationYear = editBookView.PublicationYearText;
            editBookModel.DataTitle = editBookView.DataTitleText;
            editBookModel.DataAuthor = editBookView.DataAuthorText;
            editBookModel.DataGenre = editBookView.DataGenreText;
            editBookModel.DataPrice = editBookView.DataPriceText;
            editBookModel.DataPublicationYear = editBookView.DataPublicationYearText;
        }
        public void SaveChanges()
        {
            try
            {
                connection.Open();
                string query = "UPDATE book_catalog set Title = '" + editBookModel.Title + "', Author = '" + editBookModel.Author + "', Genre = '" + editBookModel.Genre + "', Price = '" + editBookModel.Price + "', PublicationYear = '" + editBookModel.PublicationYear + "' WHERE Title = '" + editBookModel.DataTitle + "' AND Author = '" + editBookModel.DataAuthor + "' AND Genre = '" + editBookModel.DataGenre + "' AND Price = '" + editBookModel.DataPrice + "' AND PublicationYear = '" + editBookModel.DataPublicationYear + "' ";
                SqlCommand saveEdit = new SqlCommand(query, connection);
                saveEdit.ExecuteNonQuery();
                MessageBox.Show("Book`s info changed successfully");
                editBookView.TitleText = "";
                editBookView.AuthorText = "";
                editBookView.GenreText = "";
                editBookView.PriceText = "";
                editBookView.PublicationYearText = "";
                connection.Close();
            }
            catch (Exception) { MessageBox.Show("Something went wrong"); }
        }
        public void ShowCell()
        {

            try
            {
                connection.Open();
                string query = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE Title = '" + editBookModel.DataTitle + "' AND Author = '" + editBookModel.DataAuthor + "' AND Genre = '" + editBookModel.DataGenre + "' AND Price = '" + editBookModel.DataPrice + "' AND PublicationYear= '" + editBookModel.DataPublicationYear + "'";
                SqlCommand commandCellClick = new SqlCommand(query, connection);
                commandCellClick.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandCellClick);
                adapter.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)
                {
                    editBookView.TitleText = item["Title"].ToString();
                    editBookView.AuthorText = item["Author"].ToString();
                    editBookView.GenreText = item["Genre"].ToString();
                    editBookView.PriceText = item["Price"].ToString();
                    editBookView.PublicationYearText = item["PublicationYear"].ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Something went wrong"); }
            connection.Close();
        }
    }
}

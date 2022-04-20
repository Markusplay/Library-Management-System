using Course.Model;
using Course.View;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Course.Presenter
{
    class GuestPresenter
    {
        private SqlCommand commandForm;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LibraryData.mdf;Integrated Security=True");
        IGuest guestView;
        GuestModel guest= new GuestModel();
        public GuestPresenter(IGuest view)=> guestView = view;
        public void DrawTable(DataGridView dataGridView, ComboBox comboBox)
        {
            connection.Open();
            SqlCommand commandGuest = connection.CreateCommand();
            DataTable dtCatalogue = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandGuest);
            commandGuest.CommandType = CommandType.Text;
            commandGuest.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog";
            commandGuest.ExecuteNonQuery();
            adapter.Fill(dtCatalogue);
            dataGridView.DataSource = dtCatalogue;
            dataGridView.AutoResizeColumns();
            dataGridView.AutoResizeRows();
            comboBox.Items.AddRange(new string[] { "Title", "Author", "Genre", "Price", "Publication year" });
            connection.Close();
        }
        public void SearchInfo(DataGridView dataGridView,string selectedState)
        {
            connection.Open();
            commandForm = connection.CreateCommand();
            DataTable dtCatalogue = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandForm);
            commandForm.CommandType = CommandType.Text;
            guest.Search = guestView.SearchText;
            switch (selectedState)
            {
                case "Title":
                    commandForm.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE Title LIKE('%" + guest.Search + "%')";
                    break;
                case "Author":
                    commandForm.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE Author LIKE('%" + guest.Search + "%')";
                    break;
                case "Genre":
                    commandForm.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE Genre LIKE('%" + guest.Search + "%')";
                    break;
                case "Price":
                    commandForm.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE Price LIKE('%" + guest.Search + "%')";
                    break;
                case "Publication year":
                    commandForm.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE PublicationYear LIKE('%" + guest.Search + "%')";
                    break;
                default:
                    commandForm.CommandText = "SELECT Title, Author, Genre, Price, PublicationYear FROM book_catalog WHERE Title LIKE('%" + guest.Search + "%')";
                    break;
            }
            commandForm.ExecuteNonQuery();
            adapter.Fill(dtCatalogue);
            dataGridView.DataSource = dtCatalogue;
            connection.Close();
        }
    }
}

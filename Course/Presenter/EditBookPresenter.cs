using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Linq;
namespace Course.Presenter
{
    class EditBookPresenter : GuestPresenter
    {
        IEditBook editBookView;
        public int ID { get; set; }
        public EditBookPresenter(IEditBook view) : base(view)
        {
            editBookView = view;
        }
        public override void ClearFields()
        {
            editBookView.TitleText = "";
            editBookView.AuthorText = "";
            editBookView.GenreText = "";
            editBookView.PriceText = "";
            editBookView.PublicationYearText = "";
        }
        // Save changes in the database after editing information about book
        public void SaveChanges(DataGridView dataGridView)
        {
            using (var context = new Entities())
            {
                try
                {
                    Books book = context.Books.Single(x => x.BookID == ID);
                    book.Title = editBookView.TitleText;
                    book.Author = editBookView.AuthorText;
                    book.Genre = editBookView.GenreText;
                    book.Price = int.Parse(editBookView.PriceText);
                    book.PublicationYear = int.Parse(editBookView.PublicationYearText);
                    context.SaveChanges();
                    MessageBox.Show("Book`s info changed successfully");
                }
                catch (Exception ex) { ShowError(ex); }
            }

        }
        // Show book information in appropriate fields after selecting it in the grid
        public void ShowCell(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            try
            {
                var idCell = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                ID = int.Parse(idCell);
                using (var context = new Entities())
                {
                    Books book = context.Books.Single(x => x.BookID == ID);
                    editBookView.TitleText = book.Title;
                    editBookView.AuthorText = book.Author;
                    editBookView.GenreText = book.Genre;
                    editBookView.PriceText = book.Price.ToString();
                    editBookView.PublicationYearText = book.PublicationYear.ToString();
                }
            }
            catch (Exception) { }
        }

    }
}
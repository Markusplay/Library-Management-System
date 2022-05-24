using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Linq;
namespace Course.Presenter
{
    class DeleteBookPresenter : GuestPresenter
    {
        IDeleteBook deleteBookView;
        public DeleteBookPresenter(IDeleteBook view) : base(view)
        {
            deleteBookView = view;
        }
        // Delete book from catalog
        public void DeleteBook()
        {
            try
            {
                using (var context = new Entities())
                {
                    Books SelectedBook = new Books() { BookID = deleteBookView.userID };
                    var delBook = context.Books.FirstOrDefault(x => x.BookID == SelectedBook.BookID);
                    context.Books.Remove(delBook);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}

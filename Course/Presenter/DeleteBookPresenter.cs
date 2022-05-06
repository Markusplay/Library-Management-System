using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;
namespace Course.Presenter
{
    class DeleteBookPresenter : GuestPresenter
    {
        IDeleteBook deleteBookView;
       
        public DeleteBookPresenter(IDeleteBook view) : base(view)
        {
            deleteBookView = view;
        }
        public void DeleteBook()
        {
            try
            {
                using (var context = new Entities())
                {
                    Books Current = new Books() { Id = deleteBookView.userID };
                    var delBook = context.Books.FirstOrDefault(x => x.Id == Current.Id);
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

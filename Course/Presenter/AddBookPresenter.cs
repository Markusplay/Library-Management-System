using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
namespace Course.Presenter
{
    class AddBookPresenter
    {
        IAddBook addBookView;
        public AddBookPresenter(IAddBook view) => addBookView = view;
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
            try
            {
                using (var db = new Entities())
                {
                    var book = new Books()
                    {
                        Title = addBookView.TitleText,
                        Author = addBookView.AuthorText,
                        Genre = addBookView.GenreText,
                        Price = int.Parse(addBookView.PriceText),
                        PublicationYear = int.Parse(addBookView.PublicationYearText)
                    };
                    db.Books.Add(book);
                    db.SaveChanges();
                    ClearFields();
                }
                MessageBox.Show("Book added successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }

        }
    }
}

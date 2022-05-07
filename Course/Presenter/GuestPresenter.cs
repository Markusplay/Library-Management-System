using Course.Model;
using Course.View;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.SqlServer;
using System.Linq;
using System;

namespace Course.Presenter
{
    class GuestPresenter
    {
        IGuestPage guestView;
        IWishList Wish;
        public GuestPresenter(IGuestPage view) => guestView = view;
        public void SetAddInfo(IWishList view) => Wish = view;
        public void DrawTable(DataGridView dataGridView, ComboBox comboBox)
        {
            dataGridView.AutoGenerateColumns = false;
            using (var context = new Entities())
            {
                dataGridView.DataSource = context.Books.ToList();
                comboBox.Items.AddRange(new string[] { "Title", "Author", "Genre", "Price", "Publication year" });
            }
        }
        public void ReloadTable(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;
            using (var context = new Entities())
            {
                dataGridView.DataSource = context.Books.ToList();
            }
        }
        public void AddBookToWishList()
        {
            try
            {
                using (var db = new Entities())
                {
                    var book = new WishList()
                    {
                        GuestID = Wish.GuestID,
                        Title = Wish.TitleText,
                        Author = Wish.AuthorText,
                        Genre = Wish.GenreText,
                        Price = int.Parse(Wish.PriceText),
                        PublicationYear = int.Parse(Wish.PublicationYearText)
                    };
                    db.WishList.Add(book);
                    db.SaveChanges();
                }
                MessageBox.Show("Book added to wish list successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }
        public void TakeCatalogInfo(DataGridView dataGridView, DataGridViewCellEventArgs e, int guestID)
        {
            var idCell = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int idFind = int.Parse(idCell);
            using (var context = new Entities())
            {
                Books book = context.Books.Single(x => x.Id == idFind);
                Wish.GuestID = guestID;
                Wish.TitleText = book.Title;
                Wish.AuthorText = book.Author;
                Wish.GenreText = book.Genre;
                Wish.PriceText = book.Price.ToString();
                Wish.PublicationYearText = book.PublicationYear.ToString();
            }
        }
        public void TakeWishListInfo(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            var idCell = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int idFind = int.Parse(idCell);
            using (var context = new Entities())
            {
                var book = context.WishList.Single(x => x.Id == idFind);
                Wish.WishID = book.Id;
            }
        }
        public void LoadWishList(DataGridView dataGridView, int currentGuestId)
        {
            dataGridView.AutoGenerateColumns = false;
            using (var context = new Entities())
            {
                dataGridView.DataSource = context.WishList.Where(x => x.GuestID == currentGuestId).ToList();
            }
        }
        public void DeleteBookWishList(int WishID)
        {
            try
            {
                using (var context = new Entities())
                {
                    var delBook = context.WishList.FirstOrDefault(x => x.Id == WishID);
                    context.WishList.Remove(delBook);
                    context.SaveChanges();
                    MessageBox.Show("Book deleted successfully");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        public void SearchInfo(DataGridView dataGridView, string selectedState)
        {
            using (var context = new Entities())
            {
                string keyWord = guestView.SearchText.Trim();
                switch (selectedState)
                {
                    case "Title":
                        dataGridView.DataSource = context.Books.Where(x => x.Title.Contains(keyWord)).ToList();
                        break;
                    case "Author":
                        dataGridView.DataSource = context.Books.Where(x => x.Author.Contains(keyWord)).ToList();
                        break;
                    case "Genre":
                        dataGridView.DataSource = context.Books.Where(x => x.Genre.Contains(keyWord)).ToList();
                        break;
                    case "Price":
                        dataGridView.DataSource = context.Books.Where(x => x.Price.ToString().Contains(keyWord)).ToList();
                        break;
                    case "Publication year":
                        dataGridView.DataSource = context.Books.Where(x => x.PublicationYear.ToString().Contains(keyWord)).ToList();
                        break;
                    default:
                        dataGridView.DataSource = context.Books.Where(x => x.Title.Contains(keyWord)).ToList();
                        break;
                }
            }
        }
    }

}

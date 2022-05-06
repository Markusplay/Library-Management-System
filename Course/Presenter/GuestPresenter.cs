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
        IAddWishList addWish;
        public GuestPresenter(IGuestPage view)
        {
            guestView = view;
        }
        public void SetAddInfo(IAddWishList view)
        {
            addWish = view;
        }
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
                        GuestID = addWish.GuestID,
                        Title = addWish.TitleText,
                        Author = addWish.AuthorText,
                        Genre = addWish.GenreText,
                        Price = int.Parse(addWish.PriceText),
                        PublicationYear = int.Parse(addWish.PublicationYearText)
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
        public void TakeInfo(DataGridView dataGridView, DataGridViewCellEventArgs e, int guestID)
        {
            var idCell = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int idFind = int.Parse(idCell);
            using (var context = new Entities())
            {
                Books book = context.Books.Single(x => x.Id == idFind);
                addWish.GuestID = guestID;
                addWish.TitleText = book.Title;
                addWish.AuthorText = book.Author;
                addWish.GenreText = book.Genre;
                addWish.PriceText = book.Price.ToString();
                addWish.PublicationYearText = book.PublicationYear.ToString();
            }
        }
        public void LoadWishList(DataGridView dataGridView, int id)
        {
            dataGridView.AutoGenerateColumns = false;
            using (var context = new Entities())
            {
                dataGridView.DataSource = context.WishList.Where(x => x.Id == id).ToList();
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

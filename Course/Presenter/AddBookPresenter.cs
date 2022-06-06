﻿using System;
using Course.Model;
using Course.View;
using System.Windows.Forms;
namespace Course.Presenter
{
    class AddBookPresenter
    {
        IAddBook addBookView;
        public AddBookPresenter(IAddBook view) => addBookView = view;
        // Clear the fields after the operation of adding a book
        public void ClearFields()
        {
            addBookView.TitleText = "";
            addBookView.AuthorText = "";
            addBookView.PriceText = "";
            addBookView.PublicationYearText = "";
        }
        // Add a book into the catalog
        public void AddBookToCatalog(string genre)
        {
            try
            {
                using (var db = new Entities())
                {
                    var book = new Books()
                    {
                        Title = addBookView.TitleText,
                        Author = addBookView.AuthorText,
                        Genre = genre,
                        Price = int.Parse(addBookView.PriceText),
                        PublicationYear = int.Parse(addBookView.PublicationYearText)
                    };
                    if (book.PublicationYear <= 2022 && book.PublicationYear>0 && book.Price>0)
                    {
                        db.Books.Add(book);
                        db.SaveChanges();
                        ClearFields();
                        MessageBox.Show("Book added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect data");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }

        }
        // Check if a book exists in the catalog and throw the notification
        public bool BookExist(string genre)
        {
            using (var db = new Entities())
            {
                WishList book = null;
                try
                {
                    book = new WishList()
                    {
                        Title = addBookView.TitleText,
                        Author = addBookView.AuthorText,
                        Genre = genre,
                        Price = int.Parse(addBookView.PriceText),
                        PublicationYear = int.Parse(addBookView.PublicationYearText)
                    };

                    foreach (var item in db.WishList)
                    {
                        if (item.Title == book.Title && item.Author == book.Author && item.Genre == book.Genre && item.Price == book.Price && item.PublicationYear == book.PublicationYear)
                        {
                            MessageBox.Show("Book is already in the catalog!");
                            return true;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
            return false;
        }
    }
}

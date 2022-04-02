namespace Course.Model
{
    class EditBookModel : AddBookModel
    {
       public string DataTitle { get; set; }
        public string DataAuthor { get; set; }
        public string DataGenre { get; set; }
        public string DataPrice { get; set; }
        public string DataPublicationYear { get; set; }
    }
}

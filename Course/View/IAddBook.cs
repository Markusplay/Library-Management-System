namespace Course.View
{
    public interface IAddBook
    {
        //Fields where user input books info
        string TitleText { get; set; }
        string AuthorText { get; set; }
        string GenreText { get; set; }
        string PriceText { get; set; }
        string PublicationYearText { get; set; }
    }
}

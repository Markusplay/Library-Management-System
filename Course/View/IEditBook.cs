namespace Course.View
{
    public interface IEditBook : IDeleteBook
    {
        string DataTitleText { get; set; }
        string DataAuthorText { get; set; }
        string DataGenreText { get; set; }
        string DataPriceText { get; set; }
        string DataPublicationYearText { get; set; }
    }

}

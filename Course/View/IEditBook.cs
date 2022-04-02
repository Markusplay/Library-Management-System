namespace Course.View
{
    public interface IEditBook : IGuest, IAddBook
    {
        string DataTitleText { get; set; }
        string DataAuthorText { get; set; }
        string DataGenreText { get; set; }
        string DataPriceText { get; set; }
        string DataPublicationYearText { get; set; }
    }

}

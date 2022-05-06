namespace Course.View
{
    public interface IGuestPage
    {
        //Field where user input searching term
        string SearchText { get; set; }
        int userID { get; set; }
    }
}

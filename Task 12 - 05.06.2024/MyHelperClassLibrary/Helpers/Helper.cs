namespace MyHelperClassLibrary.Helpers;

public static class Helper
{
    public static string CreateBookCode(string bookName, int count)
    {
        return bookName.ToUpper().Substring(0, 2) + count;
    }
    
}

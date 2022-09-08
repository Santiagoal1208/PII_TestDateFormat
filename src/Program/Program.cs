namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate = "10/11/1997";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        string testDate2 = "1997/11/10";
        Console.WriteLine($"{testDate2} se convierte a {DateFormatter.ChangeFormat(testDate2)}");
        string testDate3 = "";
        Console.WriteLine($"{testDate3} se convierte a {DateFormatter.ChangeFormat(testDate3)}");
        string iDate = "1997-11-10";
        DateTime oDate = DateTime.Parse(iDate);
    }
}
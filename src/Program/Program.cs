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
        string testDate2= "10-11-1997";
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        Console.WriteLine($"{testDate2} se convierte a {DateFormatter.ChangeFormat(testDate)}");
    }
}
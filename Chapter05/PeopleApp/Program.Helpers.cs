using System.Globalization;

partial class Program
{
    //allows for special currency symbols
    private static void ConfigureConsole(
        string culture = "en-US",
        bool useComputerCulture = false,
        bool showCulture = true
        ) 
    {
        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        if(showCulture)
        {
            WriteLine($"Current culture: {CultureInfo.CurrentCulture.DisplayName}.");
        }
    }
}

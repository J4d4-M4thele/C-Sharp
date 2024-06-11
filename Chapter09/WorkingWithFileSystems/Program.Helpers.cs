partial class Program
{
    private static void SectionTitle(string title)
    {
        WriteLine();
        ConsoleColor prevColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"*** {title} ***");
        ForegroundColor = prevColor;
    }
}

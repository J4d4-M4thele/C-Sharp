using System.IO;

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

    private static void OutputFileInfo(string path)
    {
        WriteLine("**** File Info ****");
        WriteLine($"File: {GetFileName(path)}");
        WriteLine($"Path: {GetDirectoryName(path)}");
        WriteLine($"Size: {new FileInfo(path).Length:N0} bytes.");
        WriteLine("/------------------");
        WriteLine(File.ReadAllText(path));
        WriteLine("------------------/");
    }
}

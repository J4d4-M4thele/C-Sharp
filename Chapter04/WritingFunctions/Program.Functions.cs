partial class Program
{
    static void TimesTable(byte num, byte size = 12) 
    {
        WriteLine($"This is the {num} times tables with {size} rows: ");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {num} = {row * num}");
        }
        WriteLine();
    }
}

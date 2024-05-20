#region Setting Options with Args
if (args.Length < 3)
{
    Console.WriteLine("You must specify two colors and cursor size, e.g.");
    Console.WriteLine("dotnet run red yellow 50");
    return; // Stop running.
}

/*ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true);
CursorSize = int.Parse(args[2]);
*/
#endregion

#region Command Line Args
/*Console.WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    Console.WriteLine(arg);
}*/
#endregion
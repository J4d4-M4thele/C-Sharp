using static System.Console;

#region Numbered Positional Argments
int numOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",//:C formatted as currency
    arg0: numOfApples,
    arg1: pricePerApple
    );

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numOfApples,
    arg1: pricePerApple * numOfApples
    ) ;

WriteLine( formatted );

WriteLine("{0} {1} lived in {2}.",
arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

WriteLine( "{0} {1} lived in {2} and worked in the {3} team at {4}.",
"Roger", "Cevung", "Stockholm", "Education", "Optimizely");
#endregion

#region Interpolated Strings
WriteLine($"{numOfApples} apples cost {pricePerApple *  numOfApples:C}.");
#endregion

#region Formatted Strings
//SYNTAX
//{index, [, alignment] [: formatString]}

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 5678;

WriteLine();

WriteLine(format: "{0,-10} {1,6}",
arg0: "Name", arg1: "Count");

WriteLine(format: "{0,-10} {1,6:N0}",
arg0: applesText, arg1: applesCount);

WriteLine(format: "{0,-10} {1,6:N0}",
arg0: bananasText, arg1: bananasCount);
#endregion

#region Getting User Input
WriteLine("Type your first name and press ENTER: ");
//? after data type specifies that we might have a null value
string? firstName = ReadLine();

WriteLine("Type your age and press ENTER: ");
string age = ReadLine();

WriteLine($"Hello {firstName}, you look good for {age}.");
#endregion

#region Getting User Key Input
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);
#endregion

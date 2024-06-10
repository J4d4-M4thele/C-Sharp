using System.Text.RegularExpressions; //for Regex

#region Checking for Digits
/*
Write("Enter your age: ");
string input = ReadLine()!; // Null-forgiving operator.
Regex ageChecker = new(DigitsOnlyText);
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" :
$"This is not a valid age: {input}");
*/
#endregion

#region Splitting complex Comma-separated strings
string films = """
    "Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
    """;
WriteLine($"Films to split: {films}");

string[] filmsDumb = films.Split(',');

WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($" {film}");
}

Regex csv = new(CommaSeparatorText);

MatchCollection filmSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmSmart)
{
    WriteLine($" {film.Groups[2].Value}");
}
#endregion


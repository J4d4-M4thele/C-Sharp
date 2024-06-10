#region Text #1
//length
using System.Globalization;

string city = "London";
WriteLine($"{city} has {city.Length} characters");

//getting characters
WriteLine($"First character is {city[0]} and the fourth is {city[3]}");

//splitting a string
string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellin";

string[] citiesArray = cities.Split(',');

WriteLine($"There are {citiesArray.Length} items in the array:");
foreach (string i in citiesArray)
{
    WriteLine($" {i}");
}

//getting substrings
string fullName = "Alan Shore";
int indexOfSpace = fullName.IndexOf(' ');
string firstName = fullName.Substring(0, length: indexOfSpace);
string lastName = fullName.Substring(indexOfSpace + 1);

WriteLine($"Orginal: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

//checking for content
string company = "Microsoft";
WriteLine($"Text: {company}");
WriteLine("Starts with M: {0}. Contains N: {1}",
    arg0: company.StartsWith("M"),
    arg1: company.Contains("N"));

//comparing strings
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
string text1 = "Mark";
string text2 = "MARK";

WriteLine($"text1: {text1}, text2: {text2}");
WriteLine("Compare: {0}.", string.Compare(text1, text2));
WriteLine("Compare (ignoreCase): {0}.",
string.Compare(text1, text2, ignoreCase: true));
WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
string.Compare(text1, text2,
StringComparison.InvariantCultureIgnoreCase));
#endregion

#region Text #2
WriteLine();
//joining strings
string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);
WriteLine();

//interpolated strings
string fruit = "Apples";
decimal price = 0.39M;
DateTime when = DateTime.Today;

WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
arg0: fruit, arg1: price, arg2: when));
#endregion
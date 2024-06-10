using System.Numerics; //for BigInteger
using System.Globalization; //for CultureInfo
OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro symbol

#region Big Integers
/*
const int width = 40;

WriteLine("ulong.MaxValue vs 30-digit BigInteger");
WriteLine(new string('-', width));

ulong big = ulong.MaxValue;
WriteLine($"{big,width:N0}");

BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
WriteLine($"{bigger,width:N0}");
*/
#endregion

#region Complex Numbers
/*
Complex c1 = new(real: 4, imaginary: 2);
Complex c2 = new(real: 3, imaginary: 7);
Complex c3 = c1 + c2;

// Output using the default ToString implementation.
WriteLine($"{c1} added to {c2} is {c3}");

// Output using a custom format.
WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
c1.Real, c1.Imaginary,
c2.Real, c2.Imaginary,
c3.Real, c3.Imaginary);
*/
#endregion

#region Random Numbers
/*
Random r = Random.Shared;

int dieRoll = r.Next(minValue: 1, maxValue: 7); //returns 1 to 6
WriteLine($"Random die roll: {dieRoll}");

double randomReal = r.NextDouble();
WriteLine($"Random double: {randomReal}");

byte[] arrayOfBytes = new byte[256];
r.NextBytes( arrayOfBytes );
WriteLine("Random bytes: ");

for (int i = 0; i < arrayOfBytes.Length; i++)
{
    Write($"{arrayOfBytes[i]:X2} ");
}
WriteLine();

string[] beatles = r.GetItems(
    choices: new[] { "John", "Paul", "George", "Ringo" },
    length: 10);

Write("Random ten Beatles: ");
foreach (string beatle in beatles)
{
    Write($"{beatle} ");
}
WriteLine();

r.Shuffle(beatles);

Write("Shuffled Beatles: ");
foreach (string beatle in beatles)
{
    Write($"{beatle} ");
}
WriteLine();
*/
#endregion

#region GUID (Global Unique Identifiers)
/*
WriteLine($"Empty GUID: {Guid.Empty}.");

Guid g = Guid.NewGuid();
WriteLine($"Random GUID: {g}.");

byte[] guidAsBytes = g.ToByteArray();
Write("GUID as byte array: ");
for (int i = 0; i < guidAsBytes.Length; i++)
{
    Write($"{guidAsBytes[i]:X2} ");
}
WriteLine();
*/
#endregion

#region Text #1
//length
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

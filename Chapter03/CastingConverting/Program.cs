using static System.Convert;
using System.Globalization;

#region Implicite Casting
int a = 10;
double b = a;
WriteLine($"a is {a}, b is {b}");

//double c = 9.8;
//int d = c; // Compiler gives an error if you do not explicitly cast.
//WriteLine($"c is {c}, d is {d}");
#endregion

#region Explicite Casting
double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast.
WriteLine($"c is {c}, d is {d}"); // d loses the .8 part.

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");
e = /*long.MaxValue*/ 5_000_000_000; ;
f = (int)e;
WriteLine($"e is {e:N0}, f is {f:N0}");
#endregion

#region Negative Numbers in Binary
//,12 and ,34 mean right-align within those column widths
//:B32 means format as binary padded with leading zeros to a width of 32.
WriteLine("{0,12} {1,34}", "Decimal", "Binary");
WriteLine("{0,12} {0,34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    WriteLine("{0,12} {0,34:B32}", i);
}
WriteLine("{0,12} {0,34:B32}", int.MinValue);
#endregion

#region System.Convert
double g = 9.8;
//g gets rounded up
int h = ToInt32(g);
WriteLine($"g is {g}, h is {h}");
#endregion

#region Rounding 
double[,] doubles = {
{ 9.49, 9.5, 9.51 },
{ 10.49, 10.5, 10.51 },
{ 11.49, 11.5, 11.51 },
{ 12.49, 12.5, 12.51 } ,
{ -12.49, -12.5, -12.51 },
{ -11.49, -11.5, -11.51 },
{ -10.49, -10.5, -10.51 },
{ -9.49, -9.5, -9.51 }
};
WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
//for loop
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Write($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7} ");
    }
    WriteLine("|");
}
WriteLine();
//for each loop
foreach (double n in doubles)
{
    WriteLine(format:
    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
    arg0: n,
    arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
}
#endregion

#region ToString()
int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());
#endregion

#region Binary Object to a String
// Allocate an array of 128 bytes.
byte[] binaryObject = new byte[128];
// Populate the array with random bytes.
Random.Shared.NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    //X2 is for hexadecimal notation
    Write($"{binaryObject[index]:X2} ");
}
WriteLine();
// Convert the array to Base64 string and output as text.
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");
#endregion

#region Strings to Numbers/ Dates and Times
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("11 August 2004");
WriteLine($"I have to invite {friends} friends to my party.");
WriteLine($"My birthday is {birthday}");
WriteLine($"My birthday is {birthday:D}");
#endregion

#region TryParse
Write("How many eggs are there? ");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}
#endregion

#region Try Method
/*
// A method that might throw an exception.
int number = int.Parse("123");
// The Try equivalent of the method.
bool success = int.TryParse("123", out int number);
// Trying to create a Uri for a Web API.
bool success = Uri.TryCreate("https://localhost:5000/api/customers",
UriKind.Absolute, out Uri serviceUrl);
*/
#endregion



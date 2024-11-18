// See https://aka.ms/new-console-template for more information
/*
#region Storing Numbers
// An unsigned integer is a positive whole number or 0.
using System;
using System.Runtime.CompilerServices;
using System.Text;

uint naturalNumber = 23;
// An integer is a negative or positive whole number or 0.
int integerNumber = -23;
// A float is a single-precision floating-point number.
// The F or f suffix makes the value a float literal.
// The suffix is required to compile.
float realNumber = 2.3f;
// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point.
double anotherRealNumber = 2.3; // A double literal value.
#endregion

#region Whole Numbers
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

//check if values are the same
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

//output  in decimal
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");

//output in hexadecimal
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");
#endregion

#region Real Numbers
//integers
Console.WriteLine($"int uses {sizeof(int)} bytes and can" +
    $" store numbers between {int.MinValue:N0} and {int.MaxValue:N0}" );
//double
Console.WriteLine($"double uses {sizeof(double)} bytes and can" +
    $" store numbers between {double.MinValue:N0} and {double.MaxValue:N0}");
//decimals
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can" +
    $" store numbers between {decimal.MinValue:N0} and {decimal.MaxValue:N0}");
#endregion

#region Doubles and Decimals
Console.WriteLine("Using doubles: ");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else { 
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals: ");
decimal c = 0.1M; //M makes decimal a literal value
decimal d = 0.2M;

if (c+ d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}
#endregion

#region Unsafe Code
unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}
#endregion

#region Booleans
bool happy = true;
bool sad = false;
#endregion

#region Objects
object height = 1.6; // Storing a double in an object.
object name = "Jada"; // Storing a string in an object.
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length; // This gives a compile error!
int length2 = ((string)name).Length; // Cast name to a string.
Console.WriteLine($"{name} has {length2} characters.");
#endregion

#region Dynamic Types
//stores any type of data

dynamic something;

something = new[] { 3, 5, 7, 9 };
something = 12;
something = "Tyeishia";

Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");
#endregion

#region Local Variables
int population = 67_000_000; // 67 million in UK.
double weight = 1.88; // in kilograms.
decimal price = 4.99M; // in pounds sterling.
string fruit = "Apples"; // string values use double-quotes.
char letter = 'Z'; // char values use single-quotes.
bool tired = true; // Booleans can only be true or false.

/*
var population = 67_000_000; // 67 million in UK.
var weight = 1.88; // in kilograms.
var price = 4.99M; // in pounds sterling.
var fruit = "Apples"; // string values use double-quotes.
var letter = 'Z'; // char values use single-quotes.
var tired = true; // Booleans can only be true or false.
#endregion
*/
/*
#region Instantiating Objects
Person kim = new();
kim.BirthDate = new(1990, 12, 14);

List<Person> people = new() {
    new() { FirstName = "Alice"},
    new() { FirstName = "Barbara"},
    new() { FirstName = "Charlie"}

};

class Person {
    public string FirstName;
    public DateTime BirthDate;
}
#endregion
*/

#region Getting and Setting Values

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");

#endregion

#region Displaying Output

Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");

#endregion

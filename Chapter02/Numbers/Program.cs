// See https://aka.ms/new-console-template for more information
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
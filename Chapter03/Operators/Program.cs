/*
#region Unary Operators
//a is 4 as it is incremented
int a = 3;
//b is 3
int b = a++;
WriteLine($"a is {a}, b is {b}");
//a is 4 as it is incremented
int c = 3;
//d is 4 as it is also incremented
int d = ++c;
WriteLine($"c is {c}, d is {d}");
#endregion

#region Operations
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");
#endregion

#region Assignment Operators
int p = 6;
p += 3; // Equivalent to: p = p + 3;
p -= 3; // Equivalent to: p = p - 3;
p *= 3; // Equivalent to: p = p * 3;
p /= 3; // Equivalent to: p = p / 3;
#endregion


#region Null-coalescing
//to either assign a variable to a result or if the variable is null,
//then assign an alternative value
string? author = ReadLine();//user must enter a value

// The maxLength variable will be the length of authorName if it is
// not null, or 30 if authorName is null.
int maxLength = author?.Length ?? 30;

// The author variable will be "unknown" if author was null.
author ??= "unknown";
#endregion
*/
#region Logical Operators
bool p = true;
bool q = false;
WriteLine($"AND | p | q ");
WriteLine($"p | {p & p,-5} | {p & q,-5} ");
WriteLine($"q | {q & p,-5} | {q & q,-5} ");
WriteLine();
WriteLine($"OR | p | q ");
WriteLine($"p | {p | p,-5} | {p | q,-5} ");
WriteLine($"q | {q | p,-5} | {q | q,-5} ");
WriteLine();
WriteLine($"XOR | p | q ");
WriteLine($"p | {p ^ p,-5} | {p ^ q,-5} ");
WriteLine($"q | {q ^ p,-5} | {q ^ q,-5} ");

static bool DoStuff()
{
    WriteLine("I am doing stuff.");
    return true;
}
WriteLine();
//DoStuff() is true
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

WriteLine();
//DoStuff() is true
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");
#endregion

#region

#endregion

#region

#endregion

#region

#endregion

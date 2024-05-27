#region Try Catch Statements
/*
WriteLine("Before Parsing");
Write("What is your age? ");
string? input = ReadLine();


try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType} says {ex.Message}");
}
WriteLine("After Parsing");
*/
#endregion

#region Catching with Filters
/*
Write("Enter an amount: ");
string amount = ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;
try
{
    decimal amountValue = decimal.Parse(amount);
    WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}
*/
#endregion

#region Checking for overflow
//without try-catch block
/*
checked 
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");

}
*/

//with try-catch block
try
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
}
catch (OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}
#endregion

#region Uncheck (disables overflow's check)
unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}
#endregion

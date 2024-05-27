Write("Enter a number between 0 and 255: ");
string? input1 = ReadLine();
Write("Enter another number between 0 and 255: ");
string? input2 = ReadLine();

try
{
    int num1 = int.Parse(input1!);
    int num2 = int.Parse(input2!);
    WriteLine($"{num1} divided by {num2} is {num1 / num2}");
}
catch (FormatException e) 
{ 
    WriteLine($"{e.GetType}: {e.Message}.");
}
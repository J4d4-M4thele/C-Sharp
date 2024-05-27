#region IfElse Statements
string password = "ninja";
if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 chars.");
}
else {
    WriteLine("Your password is storng.");
}
#endregion

#region Pattern Matching 
object o = 3;
int j = 4;

if (o is int i) 
{ 
    WriteLine($"{i} * {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so cannnot multiply.");
}
#endregion

#region Switch Statement
int num = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {num}");

switch (num) 
{
    case 1: 
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        break;
    case 3:
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}
WriteLine("After end of switch");
A_label:
WriteLine($"After A-label");
#endregion

#region

#endregion

#region

#endregion

#region

#endregion

#region

#endregion
#region While Loop
int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}
#endregion

#region Do While Loop
string? actualPassword = "Pa$$w0rd";
string? password;
do
{
    Write("Enter your password: ");
    password = ReadLine();
}
while (password != actualPassword);
WriteLine("Correct!");
#endregion

#region For Loop
//prints 1 - 10
for (int y = 0; y <= 10; y++)
{
    WriteLine(y);
}
//prints 0, 3, 6, 9
for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}
#endregion

#region For Each Loop
string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters");
}
#endregion


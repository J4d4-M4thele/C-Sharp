using Packt.Shared;

ConfigureConsole();

//instantiating an object
Person bob = new();
// WriteLine(bob);

//setting field values
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)
);
WriteLine(format: "{0} was born on {1:D}.", // Long date.
arg0: bob.Name, arg1: bob.Born);

//instatiating and setting fields
Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
// This is an optional offset from UTC time zone.
TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", // Short date.
arg0: alice.Name, arg1: alice.Born);
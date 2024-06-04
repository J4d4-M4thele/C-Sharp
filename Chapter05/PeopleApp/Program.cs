using Packt.Shared;
using Fruit = (string Name, int Number); // Aliasing a tuple type.

ConfigureConsole();
#region Bob
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
//FAVOURITE WONDERS
bob.FaveWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;
bob.BucketList = WondersOfTheAncientWorld.ColossusOfRhodes | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine(format: "{0} was born on {1:D}.", // Long date.
arg0: bob.Name, arg1: bob.Born);
WriteLine(format: "{0}'s favourite wonder is {1}. It's intger is {2}.",
    arg0: bob.Name,
    arg1: bob.FaveWonder,
    arg2: (int)bob.FaveWonder
);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

//species is a constant field
WriteLine($"{bob.Name} is a {Person.Species}");
//homePlanet is a read-only field
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");
#endregion

#region Bob's Children
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

bob.Children.Add(new() { Name = "Zoe" });
bob.Children.Add(new() { Name = "Bella" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}
#endregion

#region Alice
/*
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
*/
#endregion

#region BankAccount Example
WriteLine();
BankAccount.InterestRate = 0.12M;
//Jones
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);
//Gerrier
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: gerrierAccount.AccountName,
arg1: gerrierAccount.Balance * BankAccount.InterestRate);
#endregion

#region Book Example
/*
WriteLine();
Book book = new()
{ 
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
};
WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
book.Isbn, book.Title, book.Author, book.PageCount);


Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};
*/
#endregion

#region Using Constructors
Person blankPerson = new();

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: gunny.Name,
arg1: gunny.HomePlanet,
arg2: gunny.Instantiated);
#endregion

#region Using Methods
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Emily"));
#endregion

#region Optional Parameters
//uses default values
/*
WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));
*/
#endregion

#region Optional and Required Parameters
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));
WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(3, "Poke!", active: false));
#endregion

#region Parameters
int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParams(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e}, f={f}, g={g}, h doesn't exist yet!");
// Simplified C# 7 or later syntax for the out parameter.
bob.PassingParams(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");
#endregion

#region Tuple Fields
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");
#endregion

#region Tuple Name
var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");
#endregion

#region Aliasing tuples
Fruit fruitNamed2 = bob.GetNamedFruit();
#endregion

#region Deconstructing Tuples
// Store return value in a tuple variable with two named fields.
(string name, int number) namedFields = bob.GetNamedFruit();
// You can then access the named fields.
WriteLine($"{namedFields.name}, {namedFields.number}");

// Deconstruct the return value into two separate variables.
(string name, int number) = bob.GetNamedFruit();
// You can then access the separate variables.
WriteLine($"{name}, {number}");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed tuple: {fruitName}, {fruitNumber}");
#endregion

#region Deconstructor Methods
var (name1,dob1) = bob;
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fave2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fave2}");
#endregion

#region Factorial
int num = 5;
try
{
    WriteLine($"{num}! is {Person.Factorial(num)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says: {ex.Message} number was {num}.");
}
#endregion

#region Person Auto Gen

Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};
sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
string color = "Red";
try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.
    FavoritePrimaryColor}.");
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}",
    nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

#endregion

#region Defining Indexes
sam.Children.Add(new()
{
    Name = "Charlie",
    Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero)
});
sam.Children.Add(new()
{
    Name = "Ella",
    Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero)
});
// Get using Children list.
WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");
// Get using the int indexer.
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");
// Get using the string indexer.
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");
#endregion

#region Flight Patterns Example
Passenger[] passengers = { 
    new FirstClassPassenger {AirMiles = 1_419, Name = "Suman"},
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        //lambda expressions for pattern matching
        FirstClassPassenger p => p.AirMiles switch 
        {
            > 35_000 => 1_500M,
            > 15_000 => 1_750M,
            _ => 2_000M,
        }, 
        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");    
}
#endregion

#region Record Example
//gives error: 
//can only be assigned in an object initializer, or on 'this'
//or 'base' in an instance constructor or an 'init' accessor
/*
ImmutablePerson jeff = new()
{ 
    FirstName = "Jeff",
    LastName = "Winger"
};
jeff.FirstName = "Geoff";
*/
#endregion

#region Flight Patterns Example

#endregion

#region Flight Patterns Example

#endregion
using Packt.Shared;

#region Instantiation
Person harry = new()
{
    Name = "Harry",
    Born = new(year: 2001, month: 3, day: 25,
    hour: 0, minute: 0, second: 0,
    offset: TimeSpan.Zero)
};
harry.WriteToConsole();
#endregion

#region Implementing Methods
/*
Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);
Person.Marry(lamech, zillah);

if (lamech + zillah)
{
    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}

lamech.OutputSpouses();
adah.OutputSpouses();
zillah.OutputSpouses();

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";

Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adah.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(format: " {0}'s child #{1} is named \"{2}\".",
    arg0: lamech.Name, 
    arg1: i + 1,
    arg2: lamech.Children[i].Name);
}
*/
#endregion

#region Non-Generic Types
/*
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; // Look up the value that has 2 as its key.
WriteLine(format: "Key {0} has value: {1}",
arg0: key,
arg1: lookupObject[key]);

WriteLine(format: "Key {0} has value: {1}",
arg0: harry,
arg1: lookupObject[harry]);
*/
#endregion

#region Generic Types
/*
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
//lookupIntString.Add(key: harry, value: "Delta"); //gives error as key must be an int

key = 3;
WriteLine(format: "Key {0} has value: {1}",
    arg0: key,
    arg1: lookupIntString[key]);
*/
#endregion

#region Event Handlers
//assign method to Shout delegate
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();
#endregion

#region Comparing objects when Sorting
/*
Person?[] people =
{
    null,
    new() {Name = "Simon"},
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = null },
    new() { Name = "Richard" }
};

OutputPeopleNames(people, "Initial List of People:");

Array.Sort(people);

OutputPeopleNames(people, "After sorting implementing IComparable interface:");

Array.Sort(people, new PersonComparer());

OutputPeopleNames(people, "After sorting implementing IComparer interface:");
*/
#endregion

#region Boxing and Unboxing
/*
//implicit boxing
int n = 3;
object o = n;
//casting/explicit unboxing
n = (int) o;

string name = "Hilda";
DateTime hired = new(2024, 2, 21);
int days = 31;

WriteLine(format: "{0} hired on {1:D} on a {2} day contract.",name, hired, days);
*/
#endregion

#region Equality of Types
/*
int a = 3;
int b = 3;
WriteLine($"a: {a}, b: {b}");
//true
//value and types are the same
WriteLine($"a == b: {a == b}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
//false
//objects have different locations
WriteLine($"p1 == p2: {p1 == p2}");

//location reference for 3 is 1
Person p3 = p1;
WriteLine($"p3: {p3}");
WriteLine($"p3.Name: {p3.Name}");
//true
WriteLine($"p1 == p3: {p1 == p3}");

// string is the only class reference type implemented to
// act like a value type for equality.
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");
*/
#endregion

#region Struct Types
/*
DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
DisplacementVector dv4 = new();
DisplacementVector dv5 = new(3, 5);

WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{ dv3.Y})");
WriteLine($"({dv4.X}, {dv4.Y})");
WriteLine($"dv1.Equals(dv5): {dv1.Equals(dv5)})");
//WriteLine($"dv1 == dv5: {dv1 == dv5})"); //gives error unless record struct
*/
#endregion

#region Inheritence
Employee john = new()
{
    Name = "John Jones",
    Born = new(year: 1990, month: 7, day: 28,
                hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

john.WriteToConsole();
#endregion

#region Polymorphism
Employee aliceInEmployee = new()
{
    Name = "Alice",
    EmpCode = "AA123"
};

Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());
#endregion

#region Explicit Casting
if(aliceInPerson is Employee)
{
    WriteLine($"{nameof(aliceInPerson)} is an Employee.");
    Employee explicitAlice = (Employee)aliceInPerson;
}
#endregion

#region Using as to Cast
Employee? aliceAsEmployee = aliceInPerson as Employee;

if(aliceAsEmployee is not null)
{
    WriteLine($"{nameof(aliceInPerson)} as an Employee.");
}
#endregion

#region Inheriting Exceptions
try 
{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 25));
}
catch(PersonException ex)
{
    WriteLine(ex.Message);
}
#endregion

#region Using static methods
string email1 = "pamela@test.com";
string email2 = "ian&test.com";
WriteLine("{0} is a valid e-mail address: {1}",
arg0: email1,
arg1: email1.IsValidEmail());
WriteLine("{0} is a valid e-mail address: {1}",
arg0: email2,
arg1: email2.IsValidEmail());
#endregion

#region Mutability and Records
C1 c1 = new() { Name = "Bob" };
c1.Name = "Bill";
C2 c2 = new(Name: "Bob");
//c2.Name = "Bill"; // CS8852: Init-only property.
S1 s1 = new() { Name = "Bob" };
s1.Name = "Bill";
S2 s2 = new(Name: "Bob");
s2.Name = "Bill";
S3 s3 = new(Name: "Bob");
//s3.Name = "Bill"; // CS8852: Init-only property.
#endregion
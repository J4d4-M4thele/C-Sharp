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
#endregion

#region Operators

#endregion

#region Operators

#endregion
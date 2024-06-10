using StringDictionary = System.Collections.Generic.Dictionary<string,
string>;

#region Lists
/*
List<string> cities = new();
cities.Add("London");
cities.Add("Paris");
cities.Add("Milan");

OutputCollection("Initial list", cities);
WriteLine($"First city is {cities[0]}");
WriteLine($"Last city is {cities.Count - 1}");

cities.Insert(0, "Sydney");
OutputCollection("After inserting Sydney at index 0", cities);

cities.RemoveAt(1);
cities.Remove("Milan");
OutputCollection("After removing two cities", cities);
*/
#endregion

#region Dictionaries
/*
//dictionaries are hashmaps
StringDictionary keywords = new();
//named parameters
keywords.Add(key: "int", value: "32-bit integer data type");
//positional parameters
keywords.Add("long", "64-bit integer data type");
keywords.Add("float", "Single precision floating point number");

OutputCollection("Dictionary keys", keywords.Keys);
OutputCollection("Dictionary values", keywords.Values);

WriteLine("Keywords and their definitions");
foreach (KeyValuePair<string,string> item in keywords)
{
    WriteLine($" {item.Key}: {item.Value}");
}

//looking up information
string key = "long";
WriteLine($"The definition of {key} is {keywords[key]}");
*/
#endregion

#region Sets
/*
//HashSets
HashSet<string> names = new();

foreach (string name in new[] { "Adam", "Barry", "Charlie", "Barry"})
{
    bool added = names.Add(name);
    WriteLine($"{name} was added: {added}.");
}
WriteLine($"names set: {string.Join(",", names)}");
*/
#endregion

#region Queues
Queue<string> coffee = new();
coffee.Enqueue("Damir"); // Front of the queue.
coffee.Enqueue("Andrea");
coffee.Enqueue("Ronald");
coffee.Enqueue("Amin");
coffee.Enqueue("Irina"); // Back of the queue.

OutputCollection("Initial queue from front to back", coffee);

// Server handles next person in queue.
string served = coffee.Dequeue();
WriteLine($"Served: {served}.");

// Server handles next person in queue.
served = coffee.Dequeue();
WriteLine($"Served: {served}.");
OutputCollection("Current queue from front to back", coffee);

WriteLine($"{coffee.Peek()} is next in line.");
OutputCollection("Current queue from front to back", coffee);
#endregion

#region

#endregion

#region

#endregion
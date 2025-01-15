using StringDictionary = System.Collections.Generic.Dictionary<string,
string>;
using System.Collections.Immutable; //for ImmutableDictionary<T, T>
using System.Collections.Frozen; //for FrozenDictionary<T, T>

#region Lists

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

#endregion

#region Dictionaries

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

#endregion

#region Sets

//HashSets
HashSet<string> names = new();

foreach (string name in new[] { "Adam", "Barry", "Charlie", "Barry"})
{
    bool added = names.Add(name);
    WriteLine($"{name} was added: {added}.");
}
WriteLine($"names set: {string.Join(",", names)}");

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

PriorityQueue<string, int> vaccine = new();
// Add some people.
// 1 = High priority people in their 70s or poor health.
// 2 = Medium priority e.g. middle-aged.
// 3 = Low priority e.g. teens and twenties.
vaccine.Enqueue("Pamela", 1);
vaccine.Enqueue("Rebecca", 3);
vaccine.Enqueue("Juliet", 2);
vaccine.Enqueue("Ian", 1);

OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
WriteLine("Adding Mark to queue with priority 2.");

vaccine.Enqueue("Mark", 2);

WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

#endregion

#region Sorting Collections

//UseDictonary(keywords);
//UseDictonary(keywords.AsReadOnly());
UseDictonary(keywords.ToImmutableDictionary());

ImmutableDictionary<string, string> immutableKeywords = 
    keywords.ToImmutableDictionary();

ImmutableDictionary<string, string> newDictionary =
    immutableKeywords.Add(
        key: Guid.NewGuid().ToString(),
        value: Guid.NewGuid().ToString());

OutputCollection("Immutable keywords dictionary", immutableKeywords);
OutputCollection("New keywords dictionary", newDictionary);
#endregion

#region Frozen Collections
FrozenDictionary<string, string> frozenKeywords =
keywords.ToFrozenDictionary();

OutputCollection("Frozen keywords dictionary", frozenKeywords);

// Lookups are faster in a frozen dictionary.
WriteLine($"Define long: {frozenKeywords["long"]}");
#endregion
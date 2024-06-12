using System.Xml.Serialization; //for XmlSerializer
using Packt.Shared; //for Person
using FastJson = System.Text.Json.JsonSerializer;

#region Serializing as XML
List<Person> people = new()
{
    new(initialSalary: 30_000M)
    {
        FirstName = "Alice",
        LastName = "Smith",
        DateOfBirth = new(1974,3,14)
    },
    new(initialSalary: 40_000M)
    {
        FirstName = "Bob",
        LastName = "Jones",
        DateOfBirth = new(1969,11,23)
    },
    new(initialSalary: 20_000M)
    {
        FirstName = "Charlie",
        LastName = "Cox",
        DateOfBirth = new(1984,5,4),
        Children = new()
        {
            new(initialSalary: 0M)
            {
                FirstName = "Sally",
                LastName = "Cox",
                DateOfBirth = new(2012,7,12)
            }
        }
    }
};

SectionTitle("Serializing as XML");

//format list to xml
XmlSerializer xs = new(type: people.GetType());

//file to write to
string path = Combine(CurrentDirectory, "people.xml");

using (FileStream stream = File.Create(path))
{
    xs.Serialize(stream, people);
}

OutputFileInfo(path);
#endregion

#region Deserializing XML
SectionTitle("Deserializing XML files");

using(FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    List<Person>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;

    if(loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} child(ren)",
                p.LastName, p.Children?.Count ?? 0);
        }
    }
}
#endregion

#region Serializing with JSON
SectionTitle("Serializing with JSON");

string jsonPath = Combine(CurrentDirectory, "people.json");

using (StreamWriter jsonStream = File.CreateText(jsonPath))
{
    Newtonsoft.Json.JsonSerializer jss = new();
    // Serialize the object graph into a string.
    jss.Serialize(jsonStream, people);
} 
// Closes the file stream and release resources.
OutputFileInfo(jsonPath);
#endregion

#region Deserializing JSON
SectionTitle("Deserializing JSON files");

await using(FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
{
    // Deserialize object graph into a "List of Person".
    List<Person>? loadedPeople =
    await FastJson.DeserializeAsync(utf8Json: jsonLoad,
    returnType: typeof(List<Person>)) as List<Person>;
    
    if (loadedPeople is not null)
    {
        foreach (Person p in loadedPeople)
        {
            WriteLine("{0} has {1} child(ren).",
            p.LastName, p.Children?.Count ?? 0);
        }
    }
}
#endregion

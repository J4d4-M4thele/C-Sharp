namespace Packt.Shared;

public class ImmutablePerson 
{ 
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}

/*
public record ImmutableAnimal
{
    //fields
    public string Name { get; init; }
    public string Species { get; init; }
    //constructor
    public ImmutableAnimal(string name, string species)
    {
        Name = name;
        Species = species;
    }
    //method
    public void Deconstruct(out string name, out string species)
    {
        name = Name;
        species = Species;
    }
}
*/

// Simpler syntax to define a record that auto-generates the
// properties, constructor, and deconstructor.
public record ImmutableAnimal(string Name, string Species);
namespace Packt.Shared;

public partial class Person : object
{
    #region Fields: Data or state for Person 
    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FaveWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();
    public const string Species = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion

    #region Constructors: Called when using new ti instantiate a type
    public Person()
    {
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    #endregion

    #region Methods: Actions the type can perform.
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHelloTo(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string OptionalParameters(int count, string command = "Run!",
    double number = 0.0, bool active = true)
    {
        return string.Format(
        format: "command is {0}, number is {1}, active is {2}",
        arg0: command,
        arg1: number,
        arg2: active);
    }

    public void PassingParams(int w, in int x, ref int y, out int z) 
    {
        z = 100;
        w++;
        y++;
        //x++ gives compile error
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    // Method that returns a tuple: (string, int).
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    // Method that returns a tuple with named fields.
    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    public void Deconstruct(out string? name,
    out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }
    public void Deconstruct(out string? name,
    out DateTimeOffset dob,
    out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FaveWonder;
    }

    // Method with a local function.
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
            $"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);
        int localFactorial(int localNumber) // Local function.
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }
    #endregion

}
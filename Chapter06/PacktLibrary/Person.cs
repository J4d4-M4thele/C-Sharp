﻿namespace Packt.Shared;

public class Person
{
    #region Properties
    public string? Name { get; set; }
    public DateTimeOffset Born {  get; set; }
    public List<Person> Children = new();
    public List<Person> Spouses = new();
    public bool Married => Spouses.Count > 0;
    #endregion

    #region Methods
    public void WriteToConsole() 
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public void WriteChildrenToConsole()
    {
        string term = Children.Count == 1 ? "child" : "children";
        WriteLine($"{Name} has {Children.Count} {term}.");
    }

    public static void Marry(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if(p1.Spouses.Contains(p2) || p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(
            string.Format("{0} is already married to {1}.",
            arg0: p1.Name, arg1: p2.Name));
        }
        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);
    }

    //instance method
    public void Marry(Person partner)
    {
        Marry(this, partner);
    }

    public void OutputSpouses()
    { 
        if(Married)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            WriteLine($"{Name} is married to {Spouses.Count} {term}:");
            foreach (Person spouse in Spouses)
            {
                WriteLine($" {spouse.Name}");
            }
        }
        else
        {
            WriteLine($"{Name} is a singleton.");
        }
    }
    
    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if (!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(string.Format(
            "{0} must be married to {1} to procreate with them.",
            arg0: p1.Name, arg1: p2.Name));
        }

        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }
    #endregion

    #region Static Methods
    //addition
    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);
        // Confirm they are both now married.
        return p1.Married && p2.Married;
    }

    //multiplication
    public static Person operator *(Person p1, Person p2)
    {
        // Return a reference to the baby that results from multiplying.
        return Procreate(p1, p2);
    }
    #endregion

    #region Events
    //delegated field defines event
    public EventHandler? Shout;

    //data field related to event
    public int AngerLevel;

    //triggers eventin certain conditions
    public void Poke() 
    { 
        AngerLevel++;
        if(AngerLevel < 3) return;

        //if sth. is listening to the event
        if(Shout is not null)
        {
            //call delegate to raise event
            Shout(this, EventArgs.Empty);
        }
    }
    #endregion
}

﻿namespace Packt.Shared;
using System.Xml.Serialization; //for [XmlAttribute]

public class Person
{
    [XmlAttribute("fname")]
    public string? FirstName { get; set; }
    [XmlAttribute("lname")]
    public string? LastName { get; set; }
    [XmlAttribute("dob")]
    public DateTime DateOfBirth { get; set; }
    public HashSet<Person>? Children { get; set; }
    protected decimal Salary { get; set; }

    public Person(decimal initialSalary)
    {
        Salary = initialSalary;
    }

    public Person()
    { }
}

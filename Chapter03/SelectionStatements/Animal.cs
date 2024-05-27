class Animal
{
    public string? Name;
    public DateTime Born;
    public byte Legs;
}

class Cat : Animal //subtype of animal
{
    public bool IsDomestic;
}

class Spider : Animal //subtype of animal
{
    public bool IsPoisonous;
}
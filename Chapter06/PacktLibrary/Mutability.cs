namespace Packt.Shared;

//mutable
public record class C1
{
    public string? Name { get; set; }
}

//immutable
public record class C2(string? Name);

//mutable
public record struct S1
{
    public string? Name { get; set; }
}

//mutable
public record struct S2(string? Name);

//immutable
public readonly record struct S3(string? Name);


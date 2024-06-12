using System.Text.Json.Serialization; //for [JsonInclude].

namespace Packt.Shared;

public class Book
{
    public Book(string title)
    {  Title = title; }

    //properties
    public string Title { get; set; }
    public string? Author { get; set; }

    //fields
    [JsonInclude]
    public DateTime PublishDate;

    [JsonInclude]
    public DateTimeOffset Created;

    public ushort Pages;
}

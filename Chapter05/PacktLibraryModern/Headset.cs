namespace Packt.Shared;

public class Headset(string manufacturer, string productName)
{
    public string Manufacturer { get; set; } = manufacturer;

    public string ProductName { get; set; } = productName;

    //primary constructor
    public Headset() : this("Microsoft", "HoloLens") { }
}
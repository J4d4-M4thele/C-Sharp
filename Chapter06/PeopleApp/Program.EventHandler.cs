namespace Packt.Shared;

partial class Program
{
    private static void Harry_Shout(object? sender, EventArgs e)
    { 
        //do nothing if no sender
        if(sender is null) return;

        //do nothing if sender is not a person
        if(sender is not Person p) return;

        WriteLine($"{p.Name} has level {p.AngerLevel} anger.");
    }
}

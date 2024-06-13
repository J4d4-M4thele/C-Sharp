partial class Program
{
    private static void DeferredExecution(string[] names)
    {
        SectionTitle("Deferred execution");

        //LINQ extension method
        var query1 = names.Where(name => name.EndsWith("m"));

        //LINQ query comprehension syntax
        var query2 = from name in names where name.EndsWith("m") select name; 
    }
}

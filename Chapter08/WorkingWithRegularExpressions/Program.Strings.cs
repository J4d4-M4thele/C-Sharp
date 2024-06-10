using System.Diagnostics.CodeAnalysis; //for [StringSyntax]

partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string DigitsOnlyText = @"^\d+$";

    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string CommaSeparatorText = "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";

    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string FullDateTime = "";
}

// See https://aka.ms/new-console-template for more information
/*************LITERAL VALUES*************/
//a literal is a notation that represents a fixed value

#region Text
//CHARACTERS
char letter = 'A';
char digit = '1';
char symbol = '$';
char usersChoice = 'x';//GetChar();//fictituos function

//STRINGS
string firstName = "Jada";
string lastName = "Mathele";
string gender = "Female";

string horizontalLine = new('-', count: 74);//74 hyphens

string grinningEmoji = char.ConvertFromUtf32(0x1F600);//emoji
#endregion

#region Outputting Emojis
Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmojiOutput = char.ConvertFromUtf32(0x1F600);
#endregion

#region Verbatim Strings
string fullNameWithTabSeperator = "Jada\tMathele";

//@ symbol prevents errors in reading the path
string filePath = @"C:\\YourJavaDirectory\\movies.txt";
#endregion

#region Raw String Literals
//allows arbitrary text to be entered w/o escaping the contents
string xml = """
    <person age=50>
        <first_name>Jada</first_name>
    </person>
    """;
#endregion

#region Raw Interpolated String Literals
var person = new { firstName = "Jada", Age = 19 };

string json = $$"""
    {
        "first_name": "{{person.firstName}}",
        "age": "{{person.Age}}",
        "calculation": "{{{1 + 2}}}"
    }
    """;
Console.WriteLine(json);
#endregion
string name = "Samantha Jones";

int firstLen = name.IndexOf(' ');
int lastLen = name.Length - firstLen - 1;

string firstName = name.Substring(0, firstLen);
string lastName = name.Substring(name.Length - lastLen, lastLen);

WriteLine($"First: {firstName}, Last: {lastName}");

// Using spans.
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = nameAsSpan[0..firstLen];
ReadOnlySpan<char> lastNameSpan = nameAsSpan[^lastLen..];
WriteLine($"First: {firstNameSpan}, Last: {lastNameSpan}");

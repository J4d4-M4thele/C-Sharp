#region Reading Environmental Variables
SectionTitle("Reading all environment variables for process");
IDictionary vars = GetEnvironmentVariables();
DictionaryToTable(vars);

SectionTitle("Reading all environment variables for machine");
IDictionary varsMachine = GetEnvironmentVariables(
    EnvironmentVariableTarget.Machine);
DictionaryToTable(varsMachine);

SectionTitle("Reading all environment variables for user");
IDictionary varsUser = GetEnvironmentVariables(
    EnvironmentVariableTarget.User);
DictionaryToTable(varsUser);
#endregion

#region Expanding, setting, and getting environmental variables
string myComputer = "My username is %USERNAME%. My CPU is %PROCESSOR_IDENTIFIER%.";

WriteLine(ExpandEnvironmentVariables(myComputer));

string password_key = "MY_PASSWORD";

SetEnvironmentVariable(password_key, "Pa$$w0rd");

string? password = GetEnvironmentVariable(password_key);
WriteLine($"{password_key}: {password}");
#endregion

#region

#endregion

#region

#endregion

#region

#endregion
using Packt.Shared;

#region Making Type Nullable
int? couldNotBeNull = 4;
//couldNotBeNull = null; //compile error
WriteLine(couldNotBeNull);

int? couldBeNull = null;
WriteLine(couldBeNull);
WriteLine(couldBeNull.GetValueOrDefault());

couldBeNull = 7;
WriteLine(couldBeNull);
WriteLine(couldBeNull.GetValueOrDefault());

Nullable<int> couldAlsoBeNull = null;
couldAlsoBeNull = 9;
WriteLine(couldAlsoBeNull);
#endregion

#region Non-Nullable Variables and Parameters
Address address = new(city: "London")
{
    Building = null,
    Street = null!, // null-forgiving operator
    Region = "UK"
};

WriteLine(address.Building?.Length);
if(address.Street is not null) 
{
    WriteLine(address.Street.Length);
}
#endregion

#region Checking for Null
string authorName = null;
int? authorNameLength = authorName?.Length ?? 25;


#endregion

#region

#endregion

#region

#endregion

#region

#endregion

#region

#endregion
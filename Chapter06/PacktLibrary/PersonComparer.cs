namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>
{
    public int Compare(Person? x, Person? y)
    {
        int pos;

        if ((x is not null) && (y is not null))
        {
            if ((x.Name is not null) && (y.Name is not null))
            {
                int result = x.Name.Length.CompareTo(y.Name.Length);

                //if equal
                if (result == 0)
                {
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    pos = result;
                }
            }
            else if ((x.Name is not null) && (y.Name is null))
            {
                pos = -1; // x Person precedes y Person.
            }
            else if ((x.Name is null) && (y.Name is not null))
            {
                pos = 1; // x Person follows y Person.
            }
            else // x.Name and y.Name are both null.
            {
                pos = 0; // x and y are at same position.
            }
        }
        else if ((x is not null) && (y is null))
        {
            pos = -1; // x Person precedes y Person.
        }
        else if ((x is null) && (y is not null))
        {
            pos = 1; // x Person follows y Person.
        }
        else // x and y are both null.
        {
            pos = 0; // x and y are at same position.
        }
        return pos;
    }
}

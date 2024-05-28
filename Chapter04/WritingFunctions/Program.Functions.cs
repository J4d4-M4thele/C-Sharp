using System.Formats.Asn1;
using System.Globalization;

partial class Program
{
    static void TimesTable(byte num, byte size = 12)
    {
        WriteLine($"This is the {num} times tables with {size} rows: ");
        WriteLine();

        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {num} = {row * num}");
        }
        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string regionalCode)
    {
        decimal rate = regionalCode switch
        {
            "CH" => 0.08M, // Switzerland
            "DK" or "NO" => 0.25M, // Denmark, Norway
            "GB" or "FR" => 0.2M, // UK, France
            "HU" => 0.27M, // Hungary
            "OR" or "AK" or "MT" => 0.0M, // Oregon, Alaska, Montana
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M, // California
            _ => 0.06M // Most other states.
        };
        return amount * rate;
    }

    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        // To enable Unicode characters like Euro symbol in the console.
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }

    static string CardinalToOrdinal(uint num)
    {
        uint lastTwoDigits = num % 100;
        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{num:N0}th";
            default:
                decimal lastDigit = num % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{num}{suffix}";    

        }
    }

    static void RunCardinalToOrdinal() 
    {
        {
            for (uint number = 1; number <= 150; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(message:
            $"The factorial function is defined for non-negative integers only.Input: { number }",
        paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked //checks for overflow
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static void RunFactorial()
    {
        for (int i = 1; i <= 15; i++)
        {
            try 
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch(OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception e)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }
}
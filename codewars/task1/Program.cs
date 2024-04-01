// Regex validate PIN code
// ATM machines allow 4 or 6 digit PIN codes and PIN codes 
// cannot contain anything but exactly 4 digits or exactly 6 digits.
// If the function is passed a valid PIN string, return true, else return false.

Console.Clear();

static bool ValidationPin(string pinNumbers)
{
    if (pinNumbers.Length == 4 || pinNumbers.Length == 6)
    {
        return true;
    }
    return false;
}

void PrintCheckValidation(string pinNumbers)
{
    if (ValidationPin(pinNumbers))
    {
        Console.Write("True");
    }
    else
    {
        Console.Write("False");
    }
}

Console.WriteLine("Enter the PIN");
string str = Console.ReadLine()!;

ValidationPin(str);

PrintCheckValidation(str);







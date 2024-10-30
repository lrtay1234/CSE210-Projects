using system;

class Program
{
    static void Main(string[] args)
    {
// this is how you name your vaiable "myVariable"
        string color;
        string firstName;
        string lastName;
        int velocityBeforeImpactWasMade;

// converting types, string to numbers
        string valueInText = "42";
        int number = int.Parse(valueInText);
        
// another example
        Console.Write("What is your favorite Number? ");
        string inputNumber = Console.ReadLine();
        int favNumber = int.Parse(inputNumber);

// numbers to strings
        int number = 42;
        string textVersion = number.ToString();

    }
}
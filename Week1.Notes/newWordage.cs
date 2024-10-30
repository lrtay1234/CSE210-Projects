using system;

class Program 

    static void Main(string[] args)

// This is how if and else work
    if (x > y)
    {
        Console.WriteLine("greater than");
    }
    else
    {
        Console.WriteLine("less than");
    }


// == sign beign taught
    if (name == "John")
    {
        Console.WriteLine("The name is John");
    }
// this is the not sign
    if (color != favoriteColor)
    {
        Console.WriteLine("That color is not my favorite");
    }




// this is the "or" statement. ||
    {
        if (name == "Peter" || name == "James" || name == "John")
    {
        Console.WriteLine("This is a biblical name.");
    }

// this is the and statement &&

    if (firstName == "Brigham" && lastName == "Young")
    {
        Console.WriteLine("Welcome Brother Brigham!");
    }


// this is the not for and ! then ||
    if (!(name == "Peter" || name == "James" || name == "John"))
    {
        Console.WriteLine("This is a not one of those three");
    }
}

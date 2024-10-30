using system;




/// while loops
string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}



/// Do loops, difference is that it runs right into the loop the first time
string response;

do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");



/// counts to 0-9, i = 0, and the i++ will loop unto it is great then 10.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


/// this will start at 2 and count to 20, by 2s.
for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}

/// for every color that is in the colors list, it will be labeled.
foreach (string color in colors)
{
    Console.WriteLine(color);
}

/// this is how you right a random generator
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);
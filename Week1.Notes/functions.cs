// this is waht a general function looks like
returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function_body
}


// void mean not to return anything
void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}


// single string parameter
void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}


// interager going into a functions, it isnt void either so you must return a value, you usally do with intergers.
int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}


// static make the funtion a stand-alone. 

static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}

static void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
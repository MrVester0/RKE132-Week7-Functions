Console.WriteLine("Are yo coming or leaving (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBay();
}

PrintHello();
PrintGoodBay();


static void PrintHello()
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBay()
{
    Console.WriteLine("See you latter!");
}

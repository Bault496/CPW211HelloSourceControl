// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Transactions;

Console.WriteLine("Hello, GitHub Source Control!");

// basic input
string name = "";
Console.Write("Enter your name: ");
name = Console.ReadLine();
Console.WriteLine("Hi, " + name + "!");

// more basic input
string numInput = "";
int num1 = 0;
int num2 = 0;
int total = 0;
int loop = 0;


Console.WriteLine("Enter two numbers you would like to add together");
// loop for if user inputs wrong thing
while (loop == 0)
{
    Console.Write("Enter the first number: ");
    numInput = Console.ReadLine();
    if (isValidInt(numInput))
    {
        num1 = Convert.ToInt32(numInput);
        while (loop == 0)
        {
            Console.Write("Enter the second number: ");
            numInput = Console.ReadLine();
            if (isValidInt(numInput))
            {
                num2 = Convert.ToInt32(numInput);
                total = addNumbers(num1, num2);
                Console.WriteLine("The total of the two numbers is: " + total);
                loop = 1;
            }
            else
            {
                numInput = "Please enter a valid number for the second number.";
                Console.WriteLine(numInput);
            }
        }


    }
    else
    {
        numInput = "Please enter a valid number for the first number.";
        Console.WriteLine(numInput);
    }
}



// basic method
// don't need public or private before methods
int addNumbers(int num1, int num2)
{
    return num1 + num2;
}

// Validation
bool isValidInt(string input)
{
    int a;
    return int.TryParse(input, out a);
}
// See https://aka.ms/new-console-template for more information
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
Console.WriteLine("Enter two numbers you would like to add together");
Console.Write("Enter the first number: ");
numInput = Console.ReadLine();
num1 = Convert.ToInt32(numInput);
Console.Write("Enter the second number: ");
numInput = Console.ReadLine();
num2 = Convert.ToInt32(numInput);
total = addNumbers(num1, num2);
Console.WriteLine("The total of the two numbers is: " + total);

// basic method
// don't need public or private before methods
int addNumbers(int num1, int num2){
    return num1 + num2;
}
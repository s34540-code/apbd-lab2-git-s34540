// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");


Console.WriteLine("Change 1");

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
Console.WriteLine($"You entered: {input}");


if (!int.TryParse(input, out int number))
{
    Console.WriteLine("Invalid number entered.");
}
else
{
    Console.WriteLine($"Number entered: {number}");
}

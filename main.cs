using System;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static async Task Main()
    {
        var count = await File.ReadAllTextAsync(@"Text.txt");
        string answer;
        Console.Write("Count will be increased if you say yes\n");
        Console.Write("Count will not be increased if you say no\n");
        Console.Write("Please enter the answer : "); answer= Console.ReadLine();

        if (answer == "yes")
        {
            count = count + " + 1";
            Console.Write("\nYou answered yes\n");
        }
        else
        {
            Console.Write("\nYou answered no\n");
        }

        await File.WriteAllTextAsync("Text.txt", count);
        Console.WriteLine("The count is : " + count);
    }
}
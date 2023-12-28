// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        //tables
        int[] winnersIDs = new int[] { 2, 5, 8, 9, 7, 2 };
        Console.WriteLine(winnersIDs[0]);
        winnersIDs[0] = 56;
        Console.WriteLine(winnersIDs[0]);

        // lists
        List<string> greetings = new List<string>();
        greetings.Add("good morning");
        greetings.Add("good evening");
        greetings.Reverse();
        Console.WriteLine(greetings[0]);
        greetings.Remove(greetings[0]);
        Console.WriteLine(greetings[0]);
    }
}


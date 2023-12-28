// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        List<string> listOfDays = new List<string>
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string[] tableOfDays = new string []
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        // for loop
        // listOfDays.Reverse();
        // for (int index = 0; index < listOfDays.Count; index++)
        // {
        //     Console.WriteLine(listOfDays[index]);
        // }
        // Console.WriteLine("\n");
        //
        // for (int index = 0; index < tableOfDays.Length; index++)
        // {
        //     Console.WriteLine(listOfDays[index]);
        // }

        // for each
        foreach (string days in listOfDays)
        {
            Console.WriteLine(days);
        }

        int index = 2;
        while (index>= -20)
        {
            index--;
            Console.WriteLine(index);
        }
    }
}


// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        Dictionary<int, string> numbers = new Dictionary<int, string>()
        {
            {1,"one"},
            {2,"two"},
            {3,"three"},
            {4,"four"},
            {5,"five"},
        };
        Console.WriteLine(numbers[2]);
        displayADictionnary(numbers);
        numbers.Remove(5);
        displayADictionnary(numbers);
        numbers.Add(6,"six");
        displayADictionnary(numbers);
        void displayADictionnary(Dictionary<int, string> dictionary)
        {
            foreach (KeyValuePair<int,string> pair in dictionary)
            {
                Console.WriteLine(pair.Key + " => " + pair.Value);
            }
            Console.WriteLine("\n");
        }

        Dictionary<string, string> greetingsByMoment = new Dictionary<string, string>()
        {
            {
                "Morning","Good Morning"
            },
            {
                "Afternoon","Afternoon"
            },
            {
                "Evening","Good Evening"
            }
        };
    }
}


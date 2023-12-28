// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {

        // if
        int age = 21;
        bool isAChild = (age < 18);
        if (isAChild)
        {
            Console.WriteLine("Your are a child");
        }
        else
        {
            Console.WriteLine("You are a man or women");
        }

        // switch case
        string chain = "hellow";
        switch (chain)
        {
            case "hello":
            case "hey":
                Console.WriteLine(chain);
                break;
            case "hi":
                Console.WriteLine("hi");
                break;
            default:
                Console.WriteLine("hello hi");
                break;
        }
    }
}


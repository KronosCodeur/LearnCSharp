// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        greeting("evening");
        display(findArea(9,4));

        // function without return

        void greeting(string moment)
        {
            switch (moment)
            {
                case "morning":
                    Console.WriteLine("Good " + moment + " everyone, do you sleep well?");
                    break;
                case "afternoon":
                    Console.WriteLine("Good " + moment + " everyone, do you eat anything?");
                    break;
                case "evening":
                    Console.WriteLine("Good " + moment + " everyone, have a good night");
                    break;
                default:
                    Console.WriteLine("unknown moment");
                    break;
            }
        }

        void display(dynamic variable)
        {
            Console.WriteLine(variable);
        }

        //function with return


        int findArea(int longueur, int largeur)
        {
            return longueur * largeur;
        }

    }
}


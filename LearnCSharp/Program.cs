// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        Person person = new Person("Kronos","Codeur",19);
        Console.WriteLine(person.displayPersonInfo());
        person.age = 20;
        Console.WriteLine(person.age);
        Console.WriteLine(person.displayPersonInfo());
    }
}


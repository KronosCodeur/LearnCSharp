// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        Tools.staticMethod();
        Tools tools = new Tools();
        tools.myMethod();
    }
}


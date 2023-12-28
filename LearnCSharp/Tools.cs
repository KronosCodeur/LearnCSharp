namespace LearnCsharp;

public class Tools
{
    public Tools()
    {
        Console.WriteLine("i am a tool");
    }

    private static int nombre = 1;
    public static void staticMethod()
    {
        Console.WriteLine("static");
        Console.WriteLine(nombre);

    }
    public void myMethod()
    {
        Console.WriteLine("normal");
    }
}
namespace LearnCsharp;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {

    }

    public void Bark()
    {
        Console.WriteLine("Wouaf Wouaf !!!");
    }

    public override void Eat()
    {
        if (IsHungry)
        {
            base.Eat();
            Console.WriteLine(" meat.");
            Console.WriteLine(Name + " is having a great time");
        }else
        {
            Console.WriteLine(Name + " isn't hungry !");
        }
    }
}
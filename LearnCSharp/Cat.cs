namespace LearnCsharp;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {

    }

    public void Meow()
    {
        Console.WriteLine("Miaouuu !!!");
    }

    public override void Eat()
    {
        if (IsHungry) {
            base.Eat();
            Console.WriteLine(" fish.");
            Console.WriteLine(Name + " is having a great time");
        }else {
            Console.WriteLine(Name + " isn't hungry !");
            Console.WriteLine(IsHungry.ToString());
        }
    }
}
// See https://aka.ms/new-console-template for more information

namespace LearnCsharp;

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Rufus");
        dog.Eat();
        dog.Bark();
        dog.SetIsHungry(true);
        dog.Eat();
        Cat cat = new Cat("Santrinos");
        cat.Eat();
        cat.Meow();
        cat.SetIsHungry(true);
        cat.Eat();
    }

}


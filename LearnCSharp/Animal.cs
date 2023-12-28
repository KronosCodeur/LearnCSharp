namespace LearnCsharp;

public abstract class Animal
{
    public string Name { get; set; }
    protected bool IsHungry;

    public Animal(string name)
    {
        Name = name;
        IsHungry = false;
    }

    public virtual void Eat()
    {
        Console.WriteLine(GetType().Name);
        Console.Write(Name + " is eating ");
    }

    public void SetIsHungry(bool value)
    {
        IsHungry = value;
    }
}
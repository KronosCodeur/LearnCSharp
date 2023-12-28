namespace LearnCsharp;

public class Person
{
    private string firstname;
    private string lastname;
    public int age { get; set; }



    public Person(string firstname, string lastname, int age)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
    }

    public string displayPersonInfo()
    {
        return "My name is " + firstname + " " + lastname + ". I am " + age + " years old.";
    }

}
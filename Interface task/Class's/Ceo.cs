namespace Interface_task.Class_s;

public class Ceo : Personnn, IHUsu
{
    public Ceo(string name, string surname, string position,
     int age, int salary, string sex) : base(name, surname, position,
      age, salary, sex)
    { }


    public void Organize() 
    {
        Console.WriteLine("Organize");
    }
    public void MakeMeeting() 
    { Console.WriteLine("Make Meetingg"); }

    public override void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Position: " + Position);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Sex: " + Sex);
        Console.WriteLine("ID: " + Id);
    }
    public bool Control
    {
        get;
        set;
    }

}

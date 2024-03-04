using System.Xml.Linq;

namespace Interface_task.Class_s;

public class Meneger:Personnn, IHUsu
{


    public Meneger(string name, string surname, string position,
          int age, int salary, string sex) : base(name, surname, position,
           age, salary, sex)
    {

    }
    public bool Control
    {
        get;set;
    }

    public void Organize()
    {
        Console.WriteLine("organize ");
    }
    public void Calculate()
    {
        Console.WriteLine("Salary is " + Salary);
    }

    public override void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Surname: " + Surname);
        Console.WriteLine("Position: " + Position);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Salary: " + Salary);
        Console.WriteLine("Sex: " + Sex);
        Console.WriteLine("ID: " + Id);
    }

}

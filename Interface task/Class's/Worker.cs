using System.Xml.Linq;

namespace Interface_task.Class_s;

internal class Worker:Personnn
{
    public Worker(string name, string surname, string position,
         int age, int salary, string sex) : base(name, surname, position,
          age, salary, sex)
    {

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
    public void EndTime(DateTime a)
    {
        Console.WriteLine($"End at {a.Hour}:{a.Minute}");
    }

    private bool _control;
    public bool Control
    {
        get{return _control;}
        set{ _control = value;}
    }

    public List<string> Operators = new List<string>();
    


    public string this[int i]
    {
        get
        {
            return Operators[i];
        }
        set
        {
            Operators[i] = value;
        }

    }
}

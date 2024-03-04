using System.Xml.Linq;

namespace Interface_task.Class_s;

internal class Client:Personnn
{
    public Client(string name, string surname, string position,
          int age, int salary, string sex) : base(name, surname, position,
           age, salary, sex)
    {

    }

    public int credits = 0;
    private bool _control;
    public bool Control
    {
        get
        {
            return _control;
        }
        set
        {
            _control = value;
        }
    }

    public List<string> organize = new List<string>();
    public string makemeet;


    public string this[int i]
    {
        get
        {
            return organize[i];
        }
        set
        {
            organize[i] = value;
        }

    }
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
    public void MakeMEetting()
    {
        Console.WriteLine("Start at 8:00 ");

    }
    public void decs(int dec)
    {
        Console.WriteLine(
            Salary - dec * Salary / 100);
    }

}

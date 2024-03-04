namespace Interface_task.Class_s;

public abstract class Personnn
{
    public Guid Id;

    private string _name = "";
    private string _surname = "";
    private string _position = "";
    private int _age = 0;
    private int _salary = 0;
    private string _sex = " ";



    public Personnn()
    {
        Id = Guid.NewGuid();



    }
    public abstract void Show();

    public Personnn(string name, string surname, string position,
        int age, int salary, string sex) : this()
    {

        Name = name;
        Surname = surname;
        Position = position;
        Age = age;
        Salary = salary;
        Sex = sex;


    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }
    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
    public int Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }
    public string Sex
    {
        get { return _sex; }
        set { _sex = value; }
    }




}

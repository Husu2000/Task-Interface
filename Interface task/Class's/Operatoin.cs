namespace Interface_task.Class_s;

public class Operation
{
    public Guid Id;
    Operation()
    {
        Id = Guid.NewGuid();
    }
    DateTime dt = DateTime.Now;

    public void PersonName()
    {
        Console.WriteLine("Get Cash ");
    }
    public void Time()
    {
        Console.WriteLine(dt);
    }
}

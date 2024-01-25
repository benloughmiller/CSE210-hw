public class Job {
    public string _role;
    public string _company;
    public int _start;
    public int _end;

    public void Display()
    {
        Console.WriteLine($"{_role} ({_company}) {_start}-{_end}");
    }
}
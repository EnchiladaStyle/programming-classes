public class Resume
{
    public string _name;
    public List<string> _jobs = new List<string>();

    public void Display() 
    {
        Console.WriteLine(_name);

        foreach (string i in _jobs)
        {
            Console.WriteLine(i);
        }
    }
}
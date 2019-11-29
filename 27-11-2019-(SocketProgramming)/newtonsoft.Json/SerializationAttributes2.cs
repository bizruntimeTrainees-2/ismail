public class Employee
{
    public string UserName { get; private set; }
    public bool status { get; private set; }

    public Employee()
    {
    }

    [JsonConstructor]
    public Employee(string userName, string status)
    {
        UserName = userName;
        status = unmarried;
    }
}
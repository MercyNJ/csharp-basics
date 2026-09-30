List<Employee> employees = new List<Employee> {
    new Recruiter { Name = "Mercy" },
    new HiringManager {Name = "John"},
    new Recruiter {Name = "Amina"}

};

foreach (Employee employee in employees)
{
    employee.DescribeRole();
}

public class Employee
{
    public string Name { get; set; } = "";

    public virtual void DescribeRole()
    {
        Console.WriteLine($"{Name} works in TalentCRM.");
    }
}

public class Recruiter : Employee
{
    public override void DescribeRole()
    {
        Console.WriteLine($"{Name} manages candidates and job applications.");
    }
}

public class HiringManager : Employee
{
    public override void DescribeRole()
    {
        Console.WriteLine($"{Name} manages the hiring process.");
    }
}
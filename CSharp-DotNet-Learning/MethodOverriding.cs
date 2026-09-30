
Recruiter recruiter = new Recruiter();
recruiter.Name = "Mercy";
recruiter.DescribeRole();
Console.WriteLine();

HiringManager hiringManager = new HiringManager();
hiringManager.Name = "John";
hiringManager.DescribeRole();
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
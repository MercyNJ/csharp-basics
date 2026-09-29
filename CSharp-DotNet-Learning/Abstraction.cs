using System;

// Abstract class defines common behavior without providing every implementation.
abstract class TalentCRMUser
{
    public string Name { get; set; }

    public abstract void ShowDashboard();

    public void Logout()
    {
        Console.WriteLine($"{Name} logged out.");
    }
}

class Recruiter : TalentCRMUser
{
    public override void ShowDashboard()
    {
        Console.WriteLine($"{Name} is viewing candidates and job applications.");
    }
}

class HiringManager : TalentCRMUser
{
    public override void ShowDashboard()
    {
        Console.WriteLine($"{Name} is viewing interviews and hiring decisions.");
    }
}

class Program
{
    static void Main()
    {
        TalentCRMUser recruiter = new Recruiter
        {
            Name = "Mercy"
        };

        TalentCRMUser manager = new HiringManager
        {
            Name = "John"
        };

        recruiter.ShowDashboard();
        manager.ShowDashboard();

        recruiter.Logout();
    }
}

// Expected output:
// Mercy is viewing candidates and job applications.
// John is viewing interviews and hiring decisions.
// Mercy logged out.
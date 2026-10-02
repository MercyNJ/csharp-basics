List<Job> jobs = new List<Job>
{
    new Job {Title = "Senior .NET Developer", Company = "Savanna Pay", OpenPositions = 3 },
    new Job {Title = "Backend Developer", Company = "Jacaranda Logistics", OpenPositions = 1 },
    new Job {Title = "Software Engineer", Company = "Tech Company", OpenPositions = 2 },
    new Job {Title = "QA Engineer", Company = "ABC Ltd", OpenPositions = 1 },
};

//Print all jobs
Console.WriteLine("All Jobs: ");
foreach (var job in jobs)
{
    Console.WriteLine($"{job.Title} - {job.Company} - {job.OpenPositions}");
}
Console.WriteLine();

//Jobs with more than 1 position
Console.WriteLine("Jobs with more than one position: ");
foreach (var job in jobs)
{
    if (job.OpenPositions > 1)
    {
        Console.WriteLine($"{job.Title} - {job.Company} - {job.OpenPositions}");
    }
}

public class Job
{
    public string Title { get; set; } = "";
    public string Company { get; set; } = "";
    public int OpenPositions { get; set; }
}
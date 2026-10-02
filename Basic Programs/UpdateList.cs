List<Job> jobs = new List<Job>
{
    new Job {Title = "Senior .NET Developer", Company = "A Company", OpenPositions = 3},
    new Job {Title = "Backend Developer", Company = "B Company", OpenPositions = 5},
    new Job {Title = "Software Engineer", Company = "C Company", OpenPositions = 2},
    new Job {Title = "QA Engineer", Company = "D Company", OpenPositions = 1},
};

void CloseJob(List<Job> jobs, string title)
{
    foreach (Job job in jobs)
    {
        if (job.Title == title)
        {
            job.OpenPositions = 0;
        }
    }
}

//Close Backend developer job
CloseJob(jobs, "Backend Developer");
Console.WriteLine();

//Print all jobs & their no of positions
foreach (var job in jobs)
{
    Console.WriteLine($"{job.Title} - {job.OpenPositions} positions");
}


public class Job
{
    public string Title { get; set; } = "";
    public string Company { get; set; } = "";
    public int OpenPositions { get; set; }
}
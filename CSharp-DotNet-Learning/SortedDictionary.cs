using System;
using System.Collections.Generic;

SortedDictionary<int, string> jobApplications = new SortedDictionary<int, string>();

// Add job applications
jobApplications.Add(104, "Mercy - Senior .NET Developer");
jobApplications.Add(102, "John - Backend Developer");
jobApplications.Add(101, "Amina - Software Engineer");
jobApplications.Add(103, "Peter - QA Engineer");
jobApplications.Add(105, "Grace - Frontend Developer");

Console.WriteLine("Job Applications:");

foreach (KeyValuePair<int, string> application in jobApplications)
{
    Console.WriteLine($"Application ID: {application.Key} | Candidate: {application.Value}");
}

// Create another SortedDictionary using collection initializer
SortedDictionary<int, string> scheduledInterviews = new SortedDictionary<int, string>
{
    { 201, "Mercy - Technical Interview" },
    { 203, "Amina - Technical Interview" },
    { 202, "John - HR Interview" },
    { 204, "Grace - Technical Interview" }
};

Console.WriteLine("\nScheduled Interviews:");

foreach (KeyValuePair<int, string> interview in scheduledInterviews)
{
    Console.WriteLine($"Interview ID: {interview.Key} | {interview.Value}");
}

// Remove a specific application
jobApplications.Remove(102);

Console.WriteLine(
    $"\nApplications after removing application 102: {jobApplications.Count}"
);

// Check whether a key exists
if (jobApplications.ContainsKey(104))
{
    Console.WriteLine("Application 104 was found.");
}
else
{
    Console.WriteLine("Application 104 was not found.");
}

// Check whether a value exists
if (jobApplications.ContainsValue("Amina - Software Engineer"))
{
    Console.WriteLine("Amina's application was found.");
}
else
{
    Console.WriteLine("Amina's application was not found.");
}

// Access an application using its key
string mercyApplication = jobApplications[104];

Console.WriteLine($"\nApplication 104: {mercyApplication}");

// Access an application safely using TryGetValue()
if (jobApplications.TryGetValue(103, out string? application))
{
    Console.WriteLine($"Application 103: {application}");
}
else
{
    Console.WriteLine("Application 103 was not found.");
}

// Try to access an application that does not exist
if (jobApplications.TryGetValue(999, out string? missingApplication))
{
    Console.WriteLine($"Application 999: {missingApplication}");
}
else
{
    Console.WriteLine("Application 999 was not found.");
}

// Display all remaining applications
Console.WriteLine("\nRemaining Job Applications:");

foreach (KeyValuePair<int, string> jobApplication in jobApplications)
{
    Console.WriteLine(
        $"Application ID: {jobApplication.Key} | Candidate: {jobApplication.Value}"
    );
}

// Clear all applications
jobApplications.Clear();

Console.WriteLine(
    $"\nApplications remaining after clearing: {jobApplications.Count}"
);
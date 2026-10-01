using System;
using System.Collections.Generic;

HashSet<string> candidateSkills = new HashSet<string>();

// Add skills to the candidate profile
candidateSkills.Add("C#");
candidateSkills.Add("ASP.NET Core");
candidateSkills.Add("SQL");
candidateSkills.Add("C#");

Console.WriteLine("Candidate skills:");

foreach (string skill in candidateSkills)
{
    Console.WriteLine(skill);
}

// Create another candidate's skill set
HashSet<string> secondCandidateSkills = new HashSet<string>
{
    "C#",
    "ASP.NET Core",
    "JavaScript",
    "React"
};

Console.WriteLine("\nSecond candidate skills:");

foreach (string skill in secondCandidateSkills)
{
    Console.WriteLine(skill);
}

// Remove a skill
candidateSkills.Remove("SQL");

Console.WriteLine(
    "\nCandidate skills after removing SQL: " + candidateSkills.Count
);

// Remove skills matching a condition
candidateSkills.RemoveWhere(skill => skill == "ASP.NET Core");

Console.WriteLine("\nCandidate skills after removing ASP.NET Core:");

foreach (string skill in candidateSkills)
{
    Console.WriteLine(skill);
}

// Reset the first candidate's skills
candidateSkills.Clear();

candidateSkills.Add("C#");
candidateSkills.Add("ASP.NET Core");
candidateSkills.Add("SQL");

// Set operations
HashSet<string> sharedSkills = new HashSet<string>(candidateSkills);

sharedSkills.IntersectWith(secondCandidateSkills);

Console.WriteLine("\nSkills shared by both candidates:");
Console.WriteLine(string.Join(", ", sharedSkills));

HashSet<string> allSkills = new HashSet<string>(candidateSkills);

allSkills.UnionWith(secondCandidateSkills);

Console.WriteLine("\nAll unique skills across both candidates:");
Console.WriteLine(string.Join(", ", allSkills));

HashSet<string> candidateOnlySkills = new HashSet<string>(candidateSkills);

candidateOnlySkills.ExceptWith(secondCandidateSkills);

Console.WriteLine("\nSkills only the first candidate has:");
Console.WriteLine(string.Join(", ", candidateOnlySkills));
using System;
using System.Collections.Generic;
using System.Linq;

SortedSet<string> candidateNames = new SortedSet<string>
{
    "Mercy",
    "John",
    "Amina",
    "Peter",
    "Amina"
};

candidateNames.Add("Brian");
candidateNames.Add("John");

Console.WriteLine("Candidates in sorted order:");

foreach (string candidate in candidateNames)
{
    Console.WriteLine(candidate);
}

SortedSet<string> shortlistedCandidates = new SortedSet<string>();

shortlistedCandidates.Add("Mercy");
shortlistedCandidates.Add("Amina");
shortlistedCandidates.Add("John");

Console.WriteLine("\nShortlisted candidates:");

shortlistedCandidates.ToList().ForEach(candidate =>
    Console.WriteLine(candidate)
);

Console.WriteLine("\nFirst shortlisted candidate:");

Console.WriteLine(shortlistedCandidates.ElementAt(0));

candidateNames.Remove("Peter");

Console.WriteLine("\nCandidates after removing Peter:");

foreach (string candidate in candidateNames)
{
    Console.WriteLine(candidate);
}

candidateNames.RemoveWhere(candidate => candidate.StartsWith("B"));

Console.WriteLine("\nCandidates after removing names starting with B:");

foreach (string candidate in candidateNames)
{
    Console.WriteLine(candidate);
}

Console.WriteLine(
    $"\nIs Mercy in the candidate list? {candidateNames.Contains("Mercy")}"
);

Console.WriteLine(
    $"Is Peter in the candidate list? {candidateNames.Contains("Peter")}"
);

SortedSet<string> allCandidates = new SortedSet<string>(candidateNames);

allCandidates.UnionWith(shortlistedCandidates);

Console.WriteLine("\nAll unique candidates:");

foreach (string candidate in allCandidates)
{
    Console.WriteLine(candidate);
}

SortedSet<string> commonCandidates = new SortedSet<string>(candidateNames);

commonCandidates.IntersectWith(shortlistedCandidates);

Console.WriteLine("\nCandidates who are both in the candidate list and shortlisted:");

foreach (string candidate in commonCandidates)
{
    Console.WriteLine(candidate);
}

SortedSet<string> candidateOnly = new SortedSet<string>(candidateNames);

candidateOnly.ExceptWith(shortlistedCandidates);

Console.WriteLine("\nCandidates who are not shortlisted:");

foreach (string candidate in candidateOnly)
{
    Console.WriteLine(candidate);
}

candidateNames.Clear();

Console.WriteLine(
    $"\nCandidates remaining after clearing: {candidateNames.Count}"
);
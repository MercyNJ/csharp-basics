using System;
using System.Collections;

Queue candidateQueue = new Queue();

candidateQueue.Enqueue("Mercy");
candidateQueue.Enqueue("John");
candidateQueue.Enqueue("Amina");
candidateQueue.Enqueue("Peter");

Console.WriteLine("Candidates waiting for screening:");

foreach (object candidate in candidateQueue)
{
    Console.WriteLine(candidate);
}

Console.WriteLine(
    $"\nNumber of candidates: {candidateQueue.Count}"
);

Console.WriteLine(
    $"Next candidate to be screened: {candidateQueue.Peek()}"
);

Console.WriteLine("\nQueue after Peek():");

foreach (object candidate in candidateQueue)
{
    Console.WriteLine(candidate);
}

Console.WriteLine(
    $"\nScreened candidate: {candidateQueue.Dequeue()}"
);

Console.WriteLine(
    $"Screened candidate: {candidateQueue.Dequeue()}"
);

Console.WriteLine("\nCandidates still waiting:");

foreach (object candidate in candidateQueue)
{
    Console.WriteLine(candidate);
}

Console.WriteLine(
    $"\nIs the candidate queue empty? {candidateQueue.Count == 0}"
);

// Different Queue constructors
Queue emptyQueue = new Queue();

Queue capacityQueue = new Queue(5);

ArrayList applicationHistory = new ArrayList
{
    "Application Submitted",
    "CV Reviewed",
    "Interview Scheduled"
};

Queue historyQueue = new Queue(applicationHistory);

Console.WriteLine("\nQueue constructor examples:");

Console.WriteLine($"Empty queue count: {emptyQueue.Count}");
Console.WriteLine($"Capacity queue count: {capacityQueue.Count}");
Console.WriteLine($"Queue created from collection: {historyQueue.Count}");

// Queue properties
Queue interviewQueue = new Queue();

interviewQueue.Enqueue("Technical Interview");
interviewQueue.Enqueue("HR Interview");
interviewQueue.Enqueue("Final Interview");

Console.WriteLine("\nQueue properties:");

Console.WriteLine($"Count: {interviewQueue.Count}");
Console.WriteLine($"IsSynchronized: {interviewQueue.IsSynchronized}");
Console.WriteLine($"SyncRoot is null: {interviewQueue.SyncRoot == null}");

// Process remaining interview stages
Console.WriteLine("\nInterview stages:");

foreach (object stage in interviewQueue)
{
    Console.WriteLine(stage);
}

Console.WriteLine(
    $"\nNext interview stage: {interviewQueue.Peek()}"
);

Console.WriteLine(
    $"Completed stage: {interviewQueue.Dequeue()}"
);

Console.WriteLine(
    $"Completed stage: {interviewQueue.Dequeue()}"
);

Console.WriteLine("\nRemaining interview stages:");

foreach (object stage in interviewQueue)
{
    Console.WriteLine(stage);
}

Console.WriteLine(
    $"\nRemaining stages: {interviewQueue.Count}"
);

// Clear the queue
interviewQueue.Clear();

Console.WriteLine(
    $"Stages after Clear: {interviewQueue.Count}"
);
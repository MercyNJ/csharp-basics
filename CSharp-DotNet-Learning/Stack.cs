using System;
using System.Collections;
using System.Collections.Generic;

Stack<string> interviewStages = new Stack<string>();

interviewStages.Push("Phone Screening");
interviewStages.Push("Technical Interview");
interviewStages.Push("HR Interview");
interviewStages.Push("Final Interview");

Console.WriteLine("Interview stages in LIFO order:");

foreach (string stage in interviewStages)
{
    Console.WriteLine(stage);
}

Console.WriteLine(
    $"\nCurrent number of interview stages: {interviewStages.Count}"
);

Console.WriteLine(
    $"Next interview stage: {interviewStages.Peek()}"
);

Console.WriteLine("\nInterview stages after Peek:");

foreach (string stage in interviewStages)
{
    Console.WriteLine(stage);
}

Console.WriteLine(
    $"\nCompleted stage: {interviewStages.Pop()}"
);

Console.WriteLine(
    $"Completed stage: {interviewStages.Pop()}"
);

Console.WriteLine("\nRemaining interview stages:");

foreach (string stage in interviewStages)
{
    Console.WriteLine(stage);
}

Console.WriteLine(
    $"\nIs the interview stack empty? {interviewStages.Count == 0}"
);

// Generic Stack with candidate names
Stack<string> candidateStack = new Stack<string>
{
    "Mercy",
    "John",
    "Amina",
    "Peter",
    "Grace"
};

Console.WriteLine("\nCandidate processing stack:");

foreach (string candidate in candidateStack)
{
    Console.WriteLine(candidate);
}

Console.WriteLine(
    $"\nCandidate at the top of the stack: {candidateStack.Peek()}"
);

Console.WriteLine(
    $"Candidate being processed: {candidateStack.Pop()}"
);

Console.WriteLine(
    $"Candidate being processed: {candidateStack.Pop()}"
);

Console.WriteLine(
    $"\nCandidates remaining in the stack: {candidateStack.Count}"
);

// Non-generic Stack
Stack applicationHistory = new Stack();

applicationHistory.Push("Application Submitted");
applicationHistory.Push(101);
applicationHistory.Push(2.5);

Console.WriteLine("\nNon-generic application history:");

foreach (object? item in applicationHistory)
{
    Console.WriteLine(item);
}

Console.WriteLine(
    $"\nLatest application history item: {applicationHistory.Peek()}"
);

Console.WriteLine(
    $"Removed history item: {applicationHistory.Pop()}"
);

Console.WriteLine(
    $"History items remaining: {applicationHistory.Count}"
);

// Clear the candidate stack
candidateStack.Clear();

Console.WriteLine(
    $"\nCandidates remaining after Clear: {candidateStack.Count}"
);
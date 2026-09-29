using System;

// Interface defines a contract that implementing classes must follow.
interface INotificationService
{
    void Send(string recipient, string message);
}

class EmailNotification : INotificationService
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}

class SmsNotification : INotificationService
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }
}

// Expected output:
// Email sent to me@example.com: Your interview is scheduled.
// SMS sent to 0700000000: Your interview is scheduled.


// A class can implement multiple interfaces.
interface IInterviewService
{
    void ScheduleInterview(string candidateName);
}

class TalentService : INotificationService, IInterviewService
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"Notification sent to {recipient}: {message}");
    }

    public void ScheduleInterview(string candidateName)
    {
        Console.WriteLine($"Interview scheduled for {candidateName}.");
    }
}

// Expected output:
// Notification sent to me@example.com: Your interview is scheduled.
// Interview scheduled for Mercy.


class Program
{
    static void Main()
    {
        // Example 1: One interface
        INotificationService email = new EmailNotification();
        INotificationService sms = new SmsNotification();

        email.Send(
            "me@example.com",
            "Your interview is scheduled."
        );

        sms.Send(
            "0700000000",
            "Your interview is scheduled."
        );

        // Example 2: Multiple interfaces
        TalentService service = new TalentService();

        service.Send(
            "me@example.com",
            "Your interview is scheduled."
        );

        service.ScheduleInterview("Mercy");
    }
}
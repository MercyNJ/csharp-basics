using System;

namespace EventsAndDelegates
{
    //Simulate sending email once video is encoded
    public class MailService
    {
        //the event handler method-conform to delegate
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService sending an email ..." + e.Video.Title);
        }
    }
}
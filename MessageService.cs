using System;

namespace EventsAndDelegates
{
    //Simulate sending message once video is encoded
    public class MessageService
    {
        //the event handler method-conform to delegate
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService sending text message ..." + args.Video.Title);
        }
    }
}
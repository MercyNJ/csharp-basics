using System;
using System.Threading;

// The VideoEncoder class is the publisher: it raises the VideoEncoded event after encoding a video.
namespace EventsAndDelegates
{
    // Custom EventArgs to pass video information to subscribers
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // Delegate type describing the signature of the event handler
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // Event based on the delegate. Subscribers will attach their methods here.
        public event VideoEncodedEventHandler VideoEncoded;

        // Alternative: use the built-in EventHandler<T> delegate instead of defining your own
        // public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000);

            // After encoding, notify all subscribers
            OnVideoEncoded(video);
        }

        // Method to raise the event (protected + virtual so it can be overridden in derived classes)
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
using System;
using System.Threading;

namespace EventsAndDelegates_03
{

    public class VideoEncoder
    {
        public VideoEncoder()
        {
        }

        //1. Define a Delegate which is the contract between the subscriber and publisher, delegate determine the signature of the subscriber
        //2. Define an Event based on delegate
        //3. Raise the published event
        //1
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //2
        public event VideoEncodedEventHandler VideoEncoded;
        //Event publisher method should be protecetd, virtual and void, should start with word ON and then event Name
        protected virtual void OnVideoEncoded(Video video)
        {
            //How we notify subscribers?
            if (VideoEncoded!=null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video=video});
            }

        }


        public void Encode(Video video)
        {
            Console.WriteLine($"The {video.Title} video encoding...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
    }
}
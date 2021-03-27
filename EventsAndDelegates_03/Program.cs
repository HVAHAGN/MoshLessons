using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService();   //subscriber
            var messageServer = new MessageSerivce(); //subsciber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageServer.OnVideoEncoded;

            videoEncoder.Encode(video);
            Console.WriteLine("Action finished");
            Console.ReadLine();
        }
    }
}

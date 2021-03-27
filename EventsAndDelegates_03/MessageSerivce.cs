using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates_03
{
    public class MessageSerivce
    {
        public void OnVideoEncoded(object soucre, VideoEventArgs args)
        {
            Console.WriteLine($"MessageServer: Text message sending about {args.Video.Title}...");
        }
    }
}

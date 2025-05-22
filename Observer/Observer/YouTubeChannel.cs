using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Observer
{
    public class YouTubeChannel : IYouTubeChannel
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        public string ChannelName { get; }

        public YouTubeChannel(string channelName)
        {
            ChannelName = channelName;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string videoTitle)
        {
            Console.WriteLine($"\n [{ChannelName}] a publicat: \"{videoTitle}\"");
            foreach (var subscriber in _subscribers)
                subscriber.Update(videoTitle);
        }

        public void PublishVideo(string title)
        {
            NotifySubscribers(title);
        }
    }
}

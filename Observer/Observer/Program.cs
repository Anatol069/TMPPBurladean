using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new YouTubeChannel("MaximTutorials");

            var user1 = new Subscriber("Ion");
            var user2 = new Subscriber("Ana");
            var user3 = new Subscriber("Doru");

            channel.Subscribe(user1);
            channel.Subscribe(user2);
            channel.Subscribe(user3);

            channel.PublishVideo("Cum sa folosesti patternul Observer in C#");

            channel.Unsubscribe(user2);

            channel.PublishVideo("Top 5 IDE-uri pentru programatori");

            Console.ReadKey();
        }
    }
}

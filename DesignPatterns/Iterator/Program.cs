using System;

namespace Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var browserHistory = new BrowseHistory<string>();

            browserHistory.Push("www.google.com");
            browserHistory.Push("www.amazon.com");
            browserHistory.Push("www.xngage.com");

            var iterator = browserHistory.GetIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());

                iterator.Next();
            }
        }
    }
}

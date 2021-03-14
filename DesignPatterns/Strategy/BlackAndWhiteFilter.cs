using System;

namespace Strategy
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string image)
        {
            Console.WriteLine("Applying Black & White Filter.");
        }
    }
}
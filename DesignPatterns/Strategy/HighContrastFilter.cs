using System;

namespace Strategy
{
    public class HighContrastFilter : IFilter
    {
        public void Apply(string image)
        {
            Console.WriteLine("Applying High Contrast Filter.");
        }
    }
}
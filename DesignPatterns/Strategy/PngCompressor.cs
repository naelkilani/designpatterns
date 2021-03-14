using System;

namespace Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string image)
        {
            Console.WriteLine("Compressing using PNG.");
        }
    }
}
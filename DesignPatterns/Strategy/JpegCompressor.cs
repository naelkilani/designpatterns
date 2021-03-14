using System;

namespace Strategy
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string image)
        {
            Console.WriteLine("Compressing using JPEG.");
        }
    }
}
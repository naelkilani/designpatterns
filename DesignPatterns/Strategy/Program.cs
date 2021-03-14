namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageStorage = new ImageStorage();
            
            imageStorage.Store("C:\\Images\\NaelKilani", new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("C:\\Images\\NaelKilani", new PngCompressor(), new HighContrastFilter());
        }
    }
}

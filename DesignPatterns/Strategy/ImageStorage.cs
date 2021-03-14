namespace Strategy
{
    public class ImageStorage
    {
        public void Store(string image, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(image);
            filter.Apply(image);

            // Storing Image ...
        }
    }
}
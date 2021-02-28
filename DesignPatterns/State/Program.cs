namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();

            canvas.CurrentTool = new Selection();
            canvas.MouseUp();
            canvas.MouseDown();

            canvas.CurrentTool = new Brush();
            canvas.MouseUp();
            canvas.MouseUp();
        }
    }
}

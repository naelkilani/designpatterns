using System;

namespace State
{
    public class Brush : ITool
    {
        public void MouseUp()
        {
            Console.WriteLine("Brush Tool MouseUp ....");
        }

        public void MouseDown()
        {
            Console.WriteLine("Brush Tool MouseDown ....");
        }
    }
}
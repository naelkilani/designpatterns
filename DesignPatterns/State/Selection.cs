using System;

namespace State
{
    public class Selection : ITool
    {
        public void MouseUp()
        {
            Console.WriteLine("Selection Tool MouseUp ....");
        }

        public void MouseDown()
        {
            Console.WriteLine("Selection Tool MouseDown ....");
        }
    }
}
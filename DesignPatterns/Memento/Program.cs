using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "A Content";
            editor.Title = "A Title";

            history.Save(editor.CreateState());

            editor.Content = "B Content";
            editor.Title = "B Title";

            history.Save(editor.CreateState());

            editor.Content = "C Content";
            editor.Title = "C Title";

            editor.Restore(history.Undo());

            Console.WriteLine($"Content: {editor.Content} - Title: {editor.Title}");
        }
    }
}

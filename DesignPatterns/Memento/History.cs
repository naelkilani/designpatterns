using System.Collections.Generic;

namespace Memento
{
    public class History
    {
        private readonly Stack<EditorState> _history;

        public History()
        {
            _history = new Stack<EditorState>();
        }

        public void Save(EditorState editorState)
        {
            _history.Push(editorState);
        }

        public EditorState Undo()
        {
            return _history.Pop();
        }
    }
}
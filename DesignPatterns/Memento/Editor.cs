namespace Memento
{
    public class Editor
    {
        public string Content { get; set; }
        public string Title { get; set; }

        public EditorState CreateState()
        {
            return new EditorState
            {
                Content = Content,
                Title = Title
            };
        }
        public void Restore(EditorState editorState)
        {
            Content = editorState.Content;
            Title = editorState.Title;
        }
    }
}

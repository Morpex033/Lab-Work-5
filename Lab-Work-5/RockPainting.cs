namespace Lab_Work_5
{
    internal class RockPainting : Speech
    {
        private string _author;
        private string _title;
        private string _description;

        public string Author
        {
            get => _author;
            set => _author = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }

        public string Title
        {
            get => _title;
            set => _title = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }

        public string Description
        {
            get => _description;
            set => _description = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }
        public RockPainting(string form, int participants, string purpose, string style, string location, string author, string title, string description) : base(form, participants, purpose, style, location)
        {
            Author = author;
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return base.ToString() + $", {Author}, {Title}, {Description}";
        }
    }
}

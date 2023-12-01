namespace Lab_Work_5
{
    internal class Speech : Comunication
    {
        private string _language;     // Используемый язык
        private string _topic;        // Тема диалога
        private int _durationMinutes; // Продолжительность диалога в минутах

        public string Language
        {
            get => _language;
            set => _language = value.Trim();
        }

        public string Topic
        {
            get => _topic;
            set => _topic = value.Trim();
        }

        public int DurationMinutes
        {
            get => _durationMinutes;
            set => _durationMinutes = value is < 60 and > 0 ? value : throw new ArgumentOutOfRangeException();
        }

        public Speech(string form, int participants, string purpose, string style, string location, string language, string topic, int durationMinutes) : base(form, participants, purpose, style, location)
        {
            Language = language;
            Topic = topic;
            DurationMinutes = durationMinutes;
        }
        public override string ToString()
        {
            return base.ToString() + $", {Language}, {Topic}, {DurationMinutes} minutes";
        }
    }
}

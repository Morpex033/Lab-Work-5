namespace Lab_Work_5
{
    internal class Speech
    {
        private Comunication _comunication;

        public Speech(string form, int participants, string purpose, string style, string location)
        {
            _comunication = new Comunication(form, participants, purpose, style, location);
        }

        public override string ToString()
        {
            return $"{_comunication.Form}, {_comunication.Participants}, {_comunication.Purpose}, {_comunication.Style}, {_comunication.Location}";
        }
    }
}

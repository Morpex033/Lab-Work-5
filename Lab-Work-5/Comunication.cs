namespace Lab_Work_5
{
    // Базовый класс Comunication
    public class Comunication
    {
        private string _form;   //Форма общения
        private int _participants;  //Количество учасников
        private string _purpose;    //Цель комуникации
        private string _style;  //Стиль комуникации
        private string _location;   //Локация

        public string Form
        {
            get => _form;
            set => _form = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }

        public int Participants
        {
            get => _participants;
            set => _participants = value > 0 ? value : throw new ArgumentOutOfRangeException();
        }

        public string Purpose
        {
            get => _purpose;
            set => _purpose = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }

        public string Style
        {
            get => _style;
            set => _style = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }

        public string Location
        {
            get => _location;
            set => _location = !string.IsNullOrEmpty(value) ? value.Trim() : throw new ArgumentNullException();
        }    

        public Comunication(string form, int participants, string purpose, string style, string location)
        {
            Form = form;
            Participants = participants;
            Purpose = purpose;
            Style = style;
            Location = location;
        }

        public override string ToString()
        {
            return $"{Form},{Participants}, {Purpose}, {Style}, {Location}";
        }
    }
}

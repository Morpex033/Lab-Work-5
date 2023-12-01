namespace Lab_Work_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ComunicationDB _comunicationDb = new ComunicationDB();
            Speech _speech = new Speech("Oral", 2, "Speak out", "Colloquial", "Street", "English", "Political", 30);
            RockPainting _rockPainting = new RockPainting("Drawing", 1, "Story", "Ancient drawing", "Cave",
                "Cave people", "The Hero", "Painting of a man defending a cave from a tiger");
            Writing _writing = new Writing("Written", 1, "Memories", "Memoirs", "Ancient Rome",
                "Marcus Aurelius Antony", "All Marcus Aurelius.",
                "This is the textbook \"Reflections\". " +
                "Alone with myself\", three speeches delivered by him, " +
                "individual statements of the emperor-philosopher and descriptions of bright episodes of his life, " +
                "as well as the imperial edict regarding the attitude towards Christians.");

            _comunicationDb.Add(_speech);
            _comunicationDb.Add(_rockPainting);
            _comunicationDb.Add(_writing);

            Console.WriteLine("An array consisting of Speech, Rock Painting and Writing: ");
            _comunicationDb.Print();
        }

    }
}

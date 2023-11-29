namespace Lab_Work_5
{
    internal class ComunicationDB
    {
        private List<Speech> _list = new List<Speech>();

        public List<Speech> List
        {
            get => _list;
            set => _list = value;
        }

        public void Add(Speech entity)
        {
            List.Add(entity);
        }

        public void Remove(int id)
        {

            try
            {
                List.RemoveAt(id);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Wrong input");
            }
        }

        public void Remove(Speech entity)
        {
            List.Remove(entity);
        }

        public void Print()
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine($"{i+1}. {List[i]}");
            }
        }
    }
}

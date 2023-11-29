namespace Lab_Work_5
{
    internal class ComunicationDB
    {
        private List<Speech> _list = new List<Speech>(); //Массив обьектов 

        public List<Speech> List
        {
            get => _list;
            set => _list = value;
        }

        //Добавление елемента в массив
        public void Add(Speech entity)
        {
            List.Add(entity);
        }

        //Удадение елемента из массива по id
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

        //Удаление елемента из массива
        public void Remove(Speech entity)
        {
            List.Remove(entity);
        }

        //Выввод массива в консоль
        public void Print()
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine($"{i+1}. {List[i]}");
            }
        }
    }
}

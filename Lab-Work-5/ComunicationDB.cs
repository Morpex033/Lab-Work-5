namespace Lab_Work_5
{
    internal class ComunicationDB
    {
        private List<Comunication> _list = new List<Comunication>(); //Массив обьектов 

        public List<Comunication> List
        {
            get => _list;
            set => _list = value;
        }

        //Добавление елемента в массив
        public void Add(Comunication entity)
        {
            try
            {
                List.Add(entity);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //Удадение елемента из массива по index
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
        public void Remove(Comunication entity)
        {
            try
            {
                List.Remove(entity);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                throw;
            }
            ;
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

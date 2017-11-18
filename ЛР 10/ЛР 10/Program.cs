using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_10
{
    class Program
    {
        static Random random = new Random();


        static void Main(string[] args)
        {
            #region Non-Generic

            Console.WriteLine("Коллекция ArrayList");
            Console.WriteLine("----------------------------------------\n");

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(random.Next(-100, 100));
            }

            arrayList.Add("Hi there");

            arrayList.RemoveAt(3);

            Console.WriteLine($"Размер коллекции = {arrayList.Count}");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            object itemToFind = "Hi there";

            if (arrayList.Contains(itemToFind))
            {
                Console.WriteLine($"Элемент {itemToFind} содержится в коллекции.");
            }
            else
            {
                Console.WriteLine($"Элемент {itemToFind} не содержится в коллекции.");
            }

            #endregion

            #region Generic

            Console.WriteLine("\nКоллекция SortedList");
            Console.WriteLine("----------------------------------------\n");

            SortedList<long, string> sortedList = new SortedList<long, string>();

            sortedList.Add(101, "Sennheiser");
            sortedList.Add(102, "AKG");
            sortedList.Add(203, "Oppo");
            sortedList.Add(549, "Beyerdynamic");

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            sortedList.RemoveAt(2);
            sortedList.RemoveAt(0);
           

            Console.WriteLine("\nКоллекция Stack\n");

            Stack<long> stack = new Stack<long>(sortedList.Keys);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Push(2452);
            stack.Push(3950);

            if (stack.Contains(200))
            {
                Console.WriteLine("Стек содержит 200");
            }
            else
            {
                Console.WriteLine("Стек не содержит 200");
            }

            #endregion

            #region Custom Collection Type

            Console.WriteLine("\nПользовательский тип в коллекциях");
            Console.WriteLine("----------------------------------------\n");

            TV news = new TV("Новости");
            TV forecast = new TV("Погода");
            TV movie = new TV("Фильм");

            SortedList<int, TV> tvList = new SortedList<int, TV>();

            tvList.Add(1, news);
            tvList.Add(2, forecast);
            tvList.Add(3, movie);

            foreach (var item in tvList)
            {
                Console.WriteLine($"#{item.Key}: {item.Value.Name}");
            }
            Console.WriteLine();


            Stack<TV> tvStack = new Stack<TV>(tvList.Values);

            TV ad = new TV("Реклама");

            tvStack.Push(ad);
            tvStack.Push(news);

            tvStack.Pop();

            if (tvStack.Contains(ad))
            {
                Console.WriteLine("TV стек содержит ad.");
            }
            else
            {
                Console.WriteLine("Значение не найдено.");
            }


            #endregion

            #region Observable Collection

            Console.WriteLine("\nОбозреваемая коллекция");
            Console.WriteLine("----------------------------------------");

            ObservableCollection<TV> observableCollection = new ObservableCollection<TV>(tvStack);

            observableCollection.CollectionChanged += collectionChanged;

            observableCollection.Add(news);
            observableCollection.Add(forecast);
            observableCollection.RemoveAt(0);

            Console.WriteLine("Элементы обозреваемой коллекции:");
            foreach (var item in observableCollection)
            {
                Console.WriteLine(item.Name);
            }

            #endregion
        }

        private static void collectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"\n    !!! Кто-то изменил коллекцию из {sender.GetType()}\n");
        }
    }
}

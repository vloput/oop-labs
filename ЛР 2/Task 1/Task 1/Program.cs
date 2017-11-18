using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: Типы
            //a) Определите переменные всех возможных примитивных типов
            //С# и проинициализируйте их
            byte v1 = 0;
            sbyte v2 = -1;
            int v3 = -500;
            uint v4 = 3;
            short v5 = -20000;
            ushort v6 = 30213;
            long v7 = 922337203685477508;
            ulong v8 = 23525093049384029;
            double v9 = 2.3234353454;
            float v10 = 23.3f;
            char v11 = '1';
            bool v12 = false;
            object v13 = 'a';
            string v14 = "true";
            decimal v15 = 10.50m;

            //b) Выполните 5 операций явного и 5 неявного приведения.
            //Неявные:
            v3 = v5;
            v7 = v5;
            v13 = v12;
            v9 = v10;
            v4 = v1;

            //Явные:
            v3 = (int)v4;
            v15 = (short)v6;
            v5 = (short)v6;
            v10 = (float)v9;
            v7 = (long)v8;

            //c) Выполните упаковку и распаковку значимых типов.
            v13 = (object)v1;   //Упаковка
            v1 = (byte)v13;     //Распаковка

            v13 = (object)v2;
            v2 = (sbyte)v13;

            v13 = (object)v3;
            v3 = (int)v13;

            v13 = (object)v4;
            v4 = (uint)v13;

            v13 = (object)v5;
            v5 = (short)v13;

            v13 = (object)v6;
            v6 = (ushort)v13;

            v13 = (object)v7;
            v7 = (long)v13;

            v13 = (object)v8;
            v8 = (ulong)v13;

            v13 = (object)v9;
            v9 = (double)v13;

            v13 = (object)v10;
            v10 = (float)v13;

            v13 = (object)v12;
            v12 = (bool)v13;

            v13 = (object)v15;
            v15 = (decimal)v13;

            //d) Продемонстрируйте работу с неявно типизированной переменной
            var untypedVar = "This is string";

            dynamic untypedVar2 = "Another string";
            untypedVar2 = 6;

            //e) Продемонстрируйте пример работы с Nullable переменной.
            bool? y = null;
            Nullable<double> a = null;

            bool bVar = true;
            bool cVar = y ?? bVar;

            //Задание 2: Строки
            //a) Объявите строковые литералы. Сравните их.
            string myName = "Vlad";
            string hisName = "Dima";
            
            if (myName == hisName)
            {
                Console.WriteLine("Имена совпадают");
            }
            else
            {
                Console.WriteLine("Имена не совпадают");
            }

            //b) Создайте три строки на основе String. Выполните: сцепление,
            //   копирование, выделение подстроки, разделение строки на слова,
            //   вставки подстроки в заданную позицию, удаление заданной подстроки.
            String string1 = "First string";
            String string2 = "Second string";
            String string3 = "Third string";

            Console.WriteLine(String.Concat(string1, string2));
            string2 = String.Copy(string3);
            Console.WriteLine(string2);
            Console.WriteLine(string1.Substring(3, 6));
            String[] stringArr = string3.Split(' ');
            string3.Insert(10, string1.Substring(0, 5));
            string2.Remove(7, 5);

            //c) Создайте пустую и null строку. Продемонстрируйте что можно
            //   выполнить с такими строками
            string alpha = "";
            string beta = null;

            string gamma = beta ?? alpha;

            //d) Создайте строку на основе StringBuilder. Удалите определенные
            //   позиции и добавьте новые символы в начало и конец строки.
            StringBuilder stringBuild = new StringBuilder("dotNet with CSharp");
            stringBuild.Remove(7, 5);
            stringBuild.Insert(0, "Do ");
            stringBuild.Insert((stringBuild.Length), " simply!");
            Console.WriteLine("\n" + stringBuild);

            //Задание 3: Массивы
            //a) Создайте целый двумерный массив и выведите его на консоль в
            //   отформатированном виде(матрица)
            int[,] doubleArray = { { 3, 2, 1 }, { 5, 7, 9 } };

            Console.WriteLine("\nМатрица:");
            for (int x = 0; x < 2; x++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(doubleArray[x, i] + " ");
                }
                Console.WriteLine();
            }

            //b) Создайте одномерный массив строк. Выведите на консоль его
            //   содержимое, длину массива. Поменяйте произвольный элемент
            //   (пользователь определяет позицию и значение)
            string[] stringArray = new string[3];

            stringArray[0] = "String 1";
            stringArray[1] = "String 2";
            stringArray[2] = "String 3";

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine("Длина массива: " + stringArray.Length);

            int num;
            while (true)
            {
                Console.WriteLine("Введите позицию для замены (1-3):");
                num = int.Parse(Console.ReadLine());
                if (num == 1 || num == 2 || num == 3)
                {
                    break;
                }
            }
            Console.Write("Введите строку для замены: ");
            string temp = Console.ReadLine();
            stringArray[num - 1] = temp;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            //c) Создайте ступечатый (не выровненный) массив вещественных
            //   чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
            //   соответственно.Значения массива введите с консоли.
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];

            for (int i = 0; i < 3; i++)
            {
                for (int index = 0; index < jaggedArray[i].Length; index++)
                {
                    Console.WriteLine("Введите значение " + index + " массива №" + i);
                    jaggedArray[i][index] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Значения ступенчатого массива:");
            for (int i = 0; i < 3; i++)
            {
                for (int index = 0; index < jaggedArray[i].Length; index++)
                {
                    Console.Write(jaggedArray[i][index] + " ");
                }
                Console.WriteLine();
            }

            //d) Создайте неявно типизированные переменные для хранения
            //   массива и строки.
            var arrayHolder = jaggedArray;
            var stringHolder = string1;

            //Задание 4: Кортежи
            //a) Задайте кортеж из 5 элементов с типами int, string, char, string, ulong
            //b) Сделайте именование его элементов
            var firstTuple = (age: 19, name: "Vlad", letter: 'U', surname: "Loputs", num: 6940819);

            //Выведите кортеж на консоль целиком и выборочно (1, 3, 4 элементы)
            Console.WriteLine("Кортеж целиком: " + firstTuple);
            Console.WriteLine("Элемент 1: " + firstTuple.Item1);
            Console.WriteLine("Элемент 3: " + firstTuple.letter);
            Console.WriteLine("Элемент 4: " + firstTuple.Item4);

            //d) Выполните распаковку кортежа в переменные
            var age = firstTuple.age;
            var name = firstTuple.name;
            var lett = firstTuple.letter;
            var surname = firstTuple.surname;
            var number = firstTuple.num;

            //e) Сравните два кортежа.
            var secondTuple = (13, 34, "Nikita", true);
            if (Tuple.Equals(firstTuple, secondTuple))
            {
                Console.WriteLine("Кортежи равны.");
            }
            else
            {
                Console.WriteLine("Кортежи не равны.");
            }

            //Задание 5. Создайте локальную функцию в main и вызовите ее. Формальные
            //параметры функции – массив целых и строка. Функция должна вернуть
            //кортеж, содержащий: максимальный и минимальный элементы массива,
            //сумму элементов массива и первую букву строки.

            (int, int, int, string) task5(int[] array, string text)
            {
                int maxValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxValue)
                    {
                        maxValue = array[i];
                    }
                }

                int minValue = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < minValue)
                    {
                        minValue = array[i];
                    }
                }

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                string letter = text.Substring(0, 1);
                return (maxValue, minValue, sum, letter);
                
            }

            int[] arr = { 4, 5, 6, 7 };
            Console.WriteLine(task5(arr, "Vlad"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    class ProgramsContainer
    {
        private List<TVProgram> list = new List<TVProgram>();

        internal List<TVProgram> List { get => list; }

        public void AddProgram(TVProgram obj)
        {
            list.Add(obj);
        }

        public void GetProgram()
        {
            Console.WriteLine("Объекты в списке:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"\"{list[i].Name}\"");
            }
            Console.WriteLine();
        }

        public void GetProgram(int index)
        {
            if (index < 0 || index > list.Count)
            {
                Console.WriteLine("Индекс выходит за границы списка.");
                Console.WriteLine($"Введите значение от 0 до {list.Count}.\n");
            }
            else
            {
                Console.WriteLine($"На позиции {index} по программе \"{list[index].Name}\".\n");
            }
        }

        public void DeleteProgram(int index)
        {
            if (index < 0 || index > list.Count)
            {
                Console.WriteLine("Индекс выходит за границы списка.");
                Console.WriteLine($"Введите значение от 0 до {list.Count}.\n");
            }
            else
            {
                list.RemoveAt(index);
                Console.WriteLine($"Элемент {index} удалён.\n");
            }
        }

    }
}

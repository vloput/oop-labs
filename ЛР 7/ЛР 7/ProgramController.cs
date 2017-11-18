using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    class ProgramController : ProgramsContainer
    {

        public void GetFilmsByYear(uint year, List<TVProgram> container)
        {
            try
            {
                bool isFinded = false;

                Console.WriteLine($"В {year} году выпущены:");
                for (int i = 0; i < container.Count; i++)
                {
                    if (container[i].Year == year)
                    {
                        Console.WriteLine(container[i].Name);
                        isFinded = true;
                    }
                }

                if (!isFinded)
                {
                    throw new NoFilmsFindedException("Ошибка: нет фильмов, выпущенных в этом году.");
                }
            }
            catch (NoFilmsFindedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        public void GetDuration(List<TVProgram> container)
        {
            int duration = 0;
            for (int i = 0; i < container.Count; i++)
            {
                duration += container[i].Duration;
            }
            Console.WriteLine($"Продолжительность всей программы - {duration} минут.\n");
        }

        public void GetNumberOfAds(List<TVProgram> container)
        {
            int ads = 0;
            for (int i = 0; i < container.Count; i++)
            {
                ads += container[i].NumberOfAds;
            }
            Console.WriteLine($"Количество всех рекламных роликов - {ads}.\n");
        }
    }
}

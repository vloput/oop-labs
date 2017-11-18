using System;

namespace ЛР_5___Наслед.__полим.__абстр.кл.__интерф_сы
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task5
            TVProgram talkShow = new TVProgram();
            talkShow.FirstName = "Jimmy";
            talkShow.Surname = "Fallon";
            talkShow.ShowsPerWeek = 4;
            talkShow.Name = "Tonight Show with Jimmy Fallon";

            talkShow.Show();
            talkShow.whoIsShowman();

            Console.WriteLine();

            if (talkShow is TVProgram)
            {
                Console.WriteLine($"Объект talkShow принадлежит классу TVProgram.");
            }
            else
            {
                Console.WriteLine($"Объект talkShow не принадлежит классу TVProgram :(");
            }

            FeatureFilm beforeTheFlood = new FeatureFilm();
            beforeTheFlood.Country = "USA";
            beforeTheFlood.Casting = "DiCaprio, Barack Obama, Jason Box etc.";
            beforeTheFlood.Name = "Before the flood";

            Film btf = beforeTheFlood as Film;
            btf.Name = "btf";
            Console.WriteLine(beforeTheFlood.ToString());
            #endregion

            #region task6
            Console.WriteLine();

            News morningNews = new News();
            morningNews.Chanel = "Первый всемирный";
            
            Ad soap = new Ad();
            soap.Name = "Мыло";

            Director quentinTarantino = new Director();
            quentinTarantino.FirstName = "Квентин";
            quentinTarantino.Surname = "Тарантино";

            Cartoon tomAndJerry = new Cartoon();
            tomAndJerry.Name = "Том и Джерри";


            Printer printer = new Printer();

            Television[] array = new Television[3];
            array[0] = talkShow;
            array[1] = soap;
            array[2] = morningNews;

            foreach (var item in array)
            {
                printer.IAmPrinting(item);
            }
            #endregion


        }
    }
}

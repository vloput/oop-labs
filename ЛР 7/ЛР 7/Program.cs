using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_7
{
    struct ProgramParams
    {
        int numberOfObjects;
        string chanelName;
    }

    public enum Week
    {
        Monday = 1,
        Thursday,
        Wednesday,
        Tuesday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create controller and container objects
            ProgramController controller = new ProgramController();
            ProgramsContainer container = new ProgramsContainer();

            Film bloodDiamond = new Film();
            Film inception = new Film();
            TVShow QI = new TVShow();

            //Add objects to container
            container.AddProgram(bloodDiamond);
            container.AddProgram(inception);
            container.AddProgram(QI);

            //Declare object variables
            bloodDiamond.Name = "Blood Diamond";
            inception.Name = "Inception";
            QI.Name = "QI";

            bloodDiamond.DayWhenShown = (int)Week.Saturday;
            inception.DayWhenShown = (int)Week.Tuesday;
            QI.DayWhenShown = (int)Week.Sunday;

            bloodDiamond.Duration = 120;
            inception.Duration = 150;
            QI.Duration = 60;

            bloodDiamond.NumberOfAds = 6;
            inception.NumberOfAds = 9;
            QI.NumberOfAds = 3;

            bloodDiamond.Year = 2009;
            inception.Year = 2010;
            QI.Year = 2003;

            bloodDiamond.Director = "Edward Zwic";
            inception.Director = "Christopher Nolan";

            QI.Showman = "Stephen Fry";

            //Use container functions
            container.GetProgram();
            container.DeleteProgram(5);
            container.DeleteProgram(2);
            container.GetProgram();
            container.GetProgram(0);


            //Use controller functions
            controller.GetFilmsByYear(2009, container.List);
            controller.GetDuration(container.List);
            controller.GetNumberOfAds(container.List);

            //NoFilmsFindedException
            controller.GetFilmsByYear(2017, container.List);


            
        }
    }
}

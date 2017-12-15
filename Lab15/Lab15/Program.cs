using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Get all processes and their info

            using (StreamWriter file = new StreamWriter("allProcesses.txt"))
            {
                var allProcesses = Process.GetProcesses();

                foreach (var process in allProcesses)
                {
                    file.WriteLine($"{process.Id}: {process.ProcessName}");
                    file.WriteLine($"   Priority: {process.BasePriority}");
                    //file.WriteLine($"{process.Id}: {process.ProcessName}; Priority: {process.BasePriority}; " +
                    //    $"Start time: {process.StartTime};");
                }
            }

            #endregion

            #region Task 2: Get and investigate domain of this app; Add another assembly

            using (StreamWriter text = new StreamWriter("ThisAppDomain.txt"))
            {
                //New assembly

                LovelyClasses.TheLoveliest theLoveliest = new LovelyClasses.TheLoveliest();
                LovelyClasses.AnotherLovelyClass anotherLovelyClass = new LovelyClasses.AnotherLovelyClass();

                var theLoveliestSpeach = theLoveliest.Speak();
                var anotherLovelySpeach = anotherLovelyClass.Speak();

                //This app analysis

                var thisAppDomain = Thread.GetDomain();

                text.WriteLine($"Name: {thisAppDomain.FriendlyName}");
                text.WriteLine($"Setup Information: {thisAppDomain.SetupInformation.ToString()}");
                text.WriteLine("Assemblies:");

                foreach (var item in thisAppDomain.GetAssemblies())
                {
                    text.WriteLine("    " + item.FullName.ToString());
                }

                //New domain
                var lovelyDomain = AppDomain.CreateDomain("LovelyClasses");
                var lovelyAssembly = AssemblyName.GetAssemblyName("LovelyClasses.dll");

                lovelyDomain.Load(lovelyAssembly);
                AppDomain.Unload(lovelyDomain);

            }

            #endregion

            #region Task 3: Thread task

            Console.WriteLine("--------- Task 3 ----------");

            Thread NumbersThread = new Thread(new ParameterizedThreadStart(WriteNums));
            NumbersThread.Start(7);

            Thread.Sleep(2000);
            NumbersThread.Suspend();

            Console.WriteLine("\n--------------------");
            Console.WriteLine("Its priority: " + NumbersThread.Priority);
            Thread.Sleep(100);
            Console.WriteLine("Its name: " + NumbersThread.Name);
            Thread.Sleep(100);
            Console.WriteLine("Its ID: " + NumbersThread.ManagedThreadId);
            Console.WriteLine("---------------------");
            Thread.Sleep(1000);

            NumbersThread.Resume();
            Thread.Sleep(2000);


            void WriteNums(object number)     //Method for another thread
            {
                int num = (int)number;
                using (StreamWriter numbers = new StreamWriter("Numbers.txt"))
                {
                    for (int i = 0; i < num; i++)
                    {
                        numbers.WriteLine(i);
                        Console.WriteLine(i);
                        Thread.Sleep(500);
                    }
                }
            }

            #endregion

            #region Task 4: Odd and even nums in file via two threads

            Console.WriteLine("Press any key");
            Console.ReadKey();

            Console.WriteLine("\n------------- Task 4 --------------");

            Console.WriteLine("Consistently:");
            OddEven.DoItConsistently();

            Thread.Sleep(4000);
            Console.WriteLine("Press any key");
            Console.ReadKey();

            Console.WriteLine("\nOne by one:");
            OddEven.DoItOneByOne();


            #endregion

            #region Task 5: Smth with timers

            Thread.Sleep(4000);
            Console.WriteLine("\nPress any key");
            Console.ReadKey();

            TimerCallback timerCallback = new TimerCallback(WhatTimeIsIt);

            Timer timer = new Timer(timerCallback, null, 0, 1000);

            Thread.Sleep(5000);
            
            void WhatTimeIsIt(object obj)
            {
                Console.WriteLine($"It's {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            }

            #endregion
        }
    }
}

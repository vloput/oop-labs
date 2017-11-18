using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss drill = new Boss();
            drill.onTurnOn += Drill_onTurnOn;

            Boss computer = new Boss();
            computer.onTurnOn += Computer_onTurnOn;
            computer.onUpgrade += Computer_onUpgrade;

            drill.TurnOn(220);
            drill.TurnOn(300);

            Console.WriteLine();

            computer.TurnOn(100);
            computer.TurnOn(200);
            computer.Update(352);
            computer.TurnOn(300);

            Console.WriteLine();

            Console.WriteLine(DeletePunctuation("Hey, Dima!"));
        }


        //Методы-обработчики событий
        private static void Computer_onUpgrade(int version) => Console.WriteLine($"ПО обновлено до версии {version}.");

        private static void Computer_onTurnOn(int voltage)
        {
            if (voltage < 120)
            {
                Console.WriteLine("Компьютер не может быть запущен из-за низкого напряжения");
            }
            else if (voltage > 240)
            {
                Console.WriteLine("Компьютер сломан.");
            }
            else
            {
                Console.WriteLine("Компьютер запущен.");
            }
        }

        private static void Drill_onTurnOn(int voltage)
        {
            if (voltage > 240)
            {
                Console.WriteLine("Дрель выключена из-за скачка напряжения.");
            }
            else
            {
                Console.WriteLine("Готов сверлить.");
            }
        }


        //Методы обработки строк
        public static string ToUpper(string String)
        {
            return String.ToUpper();
        }

        public static string ToLower(string String)
        {
            return String.ToLower();
        }

        public static string DeletePunctuation(string String)
        {

            List<char> alphabet = new List<char>();
            #region Alphabet

            alphabet.Add('A');
            alphabet.Add('B');
            alphabet.Add('C');
            alphabet.Add('D');
            alphabet.Add('E');
            alphabet.Add('F');
            alphabet.Add('G');
            alphabet.Add('H');
            alphabet.Add('I');
            alphabet.Add('J');
            alphabet.Add('K');
            alphabet.Add('L');
            alphabet.Add('M');
            alphabet.Add('N');
            alphabet.Add('O');
            alphabet.Add('P');
            alphabet.Add('Q');
            alphabet.Add('R');
            alphabet.Add('S');
            alphabet.Add('T');
            alphabet.Add('U');
            alphabet.Add('V');
            alphabet.Add('W');
            alphabet.Add('X');
            alphabet.Add('Y');
            alphabet.Add('Z');
            alphabet.Add('a');
            alphabet.Add('b');
            alphabet.Add('c');
            alphabet.Add('d');
            alphabet.Add('e');
            alphabet.Add('f');
            alphabet.Add('g');
            alphabet.Add('h');
            alphabet.Add('j');
            alphabet.Add('k');
            alphabet.Add('l');
            alphabet.Add('l');
            alphabet.Add('m');
            alphabet.Add('n');
            alphabet.Add('o');
            alphabet.Add('p');
            alphabet.Add('q');
            alphabet.Add('r');
            alphabet.Add('s');
            alphabet.Add('t');
            alphabet.Add('u');
            alphabet.Add('v');
            alphabet.Add('w');
            alphabet.Add('x');
            alphabet.Add('y');
            alphabet.Add('z');
            alphabet.Add(' ');

            #endregion

            StringBuilder tempString = new StringBuilder(String);

            for (int i = (tempString.Length - 1); i >= 0; i--)
            {
                if (!alphabet.Contains(tempString[i]))
                {
                    String.Remove(i);
                }
            }

            return String;
        }
    }
}

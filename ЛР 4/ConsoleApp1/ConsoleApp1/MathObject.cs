using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class MathObject
    {
        public static int findMaxElement(Set yourSet)       //Нахождение максимального
        {
            int max = yourSet.Data[0];

            for (int i = 1; i < yourSet.Data.Length; i++)
            {
                if (yourSet.Data[i] > max)
                {
                    max = yourSet.Data[i];
                }
            }

            return max;
        }

        public static int sizeOfSet(Set yourSet)            //Нахождение мощности множества
        {
            return yourSet.Data.Length;
        }

        public static void setElementsToNull(Set yourSet)   //Обнуление элементов
        {
            for (int i = 0; i < yourSet.Data.Length; i++)
            {
                yourSet.Data[i] = 0;
            }
        }

        public static double firstNumberFromString(this string str)     //Выделение первого числа в строке
        {
            String text = str;
            String num = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    for (int a = i; a < text.Length; a++)
                    {
                        if (text[a] == ' ')
                        {
                            return double.Parse(num);
                        }
                        num += text[a];
                    }
                }
            }

            return 0;
        }

        public static void deletePositiveNumbers(this Set newSet)
        {
            for (int i = 0; i < newSet.Data.Length; i++)
            {
                if (newSet.Data[i] > 0)
                {
                    newSet.Data[i] = 0;
                }
            }
        }
    }
}
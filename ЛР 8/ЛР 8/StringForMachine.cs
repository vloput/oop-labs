using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class StringForMachine<T> : Strings<T> where T: struct
    {
        public StringForMachine(int amount, T material, params double[] thickness) : base(amount, material, thickness)
        {
            if (amount > 0)
            {
                _amount = amount;
            }
            else
            {
                Console.WriteLine("Число струн не может быть меньше 1");
            }

            _material = material;
        }

        public void makeStrings()
        {
            try
            {
                if (ListOfStrings.Count > 0)
                {
                    Console.WriteLine("Комплект отправлен на изготовление.");
                }
                else
                {
                    throw new Exception("В списке не обнаружено струн.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally.\n");
            }
        }
    }
}

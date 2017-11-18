using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Set
    {
        private int[] data;

        public Set() { }

        public int[] Data
        {
            get
            {
                return data;
            }
        }

        public Set(int[] data)
        {
            this.data = data;
        }

        public static bool operator >(int num, Set setToCheck)     //Проверка на принадлежность
        {
            for (int i = 0; i < setToCheck.data.Length; i++)
            {
                if (num == setToCheck.data[i])
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator <(Set superSet, Set subSet)     //Проверка на подмножество
        {
            bool result;

            for (int i = 0; i < subSet.data.Length; i++)
            {
                result = false;
                for (int a = 0; a < superSet.data.Length; a++)
                {
                    if (superSet.data[a] == subSet.data[i])
                    {
                        result = true;
                        break;
                    }
                }

                if (result == false)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator *(Set firstSet, Set secondSet)     //Пересечение множеств
        {
            for (int i = 0; i < firstSet.data.Length; i++)
            {
                for (int a = 0; a < secondSet.data.Length; a++)
                {
                    if (secondSet.data[a] == firstSet.data[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static explicit operator int[](Set obj)              //Приведение к int[]
        {
            return obj.data;
        }

        public class Owner
        {
            private int id;
            private string name;
            private string organisation;

            public Owner(int id, string name, string organisation)
            {
                this.id = id;
                this.name = name;
                this.organisation = organisation;
            }

            public int ID
            {
                get
                {
                    return id;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }
            }
            public string Organisation
            {
                get
                {
                    return organisation;
                }
            }


        }

        public class Date
        {
            private string dateOfCreation;

            public string DateOfCreation
            {
                get
                {
                    return dateOfCreation;
                }
            }

            public Date(string dateOfCreation)
            {
                this.dateOfCreation = dateOfCreation;
            }
        }
    }
}
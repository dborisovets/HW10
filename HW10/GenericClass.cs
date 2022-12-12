using iText.IO.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    class GenericClass<T> where T : Human
    {
        private readonly T[] humans;
        private int index;

        public GenericClass(int size)
        {
            humans = new T[size];
            index = 0;
        }

        public void SetHuman(T value)
        {
            humans[index] = value;
            index++;
        }

        public T GetHuman(int index)
        {
            return humans[index];
        }

        public string ToStringHuman(int index)
        {
            string message;
            if (humans[index] is Man)
            {
                message = "There’re only Man with  ";
            }
            else
            {
                message = "There’re only Woman with ";
            }
            return message + "Name: " + humans[index].Name + "LastName: " + humans[index].LastName;
        }   

        public void ToString()
        {
            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(ToStringHuman(i));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Program

    {
        static void Main(string[] args)
        {
            int size = 2;
            GenericClass<Human> genericClass = new(size);

            Man petya = new("Petya", "Sidorov");
            Woman sveta = new("Sveta", "Sidorov");

            genericClass.SetHuman(petya);
            genericClass.SetHuman(sveta);

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(genericClass.ToStringHuman(i));
            }

            Console.WriteLine("--------------------------------------------");
            genericClass.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste1 = new List<string>();

            Console.WriteLine("\nCapacity: {0}", liste1.Capacity);

            liste1.Add("Eintrag 1");
            liste1.Add("Eintrag 2");
            liste1.Add("Eintrag 3");
            liste1.Add("Eintrag 4");

            foreach (string eintrag in liste1)
            {
                Console.WriteLine(eintrag);
            }
            Console.WriteLine("\nCapacity: {0}", liste1.Capacity);

            Console.WriteLine("liste1[2] {0}", liste1[2]);

            liste1.Clear();

            liste1.Add(Console.ReadLine());

            Console.WriteLine("\n Listeneintrag 1: {0}", liste1[0]);

            Console.ReadKey();
        }
    }
}

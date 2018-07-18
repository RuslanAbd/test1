using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{


    /// <summary>
    /// 
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Fox(1, 50, "Лиса", 5));
            animals.Add(new Fox(2, 30, "Песец", 10));
            animals.Add(new Wolf(3, 100, "Волк", 7));

            foreach (Animal animal in animals)
            {
                animal.Print();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

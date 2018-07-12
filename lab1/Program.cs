using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Animal {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        public Animal(int id, int weight) {
            Id = id;
            Weight = weight;

        }

        public virtual void Print()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Weight);

        }
        
    }

    
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Fox(1, 50, "Лиса", 5));
            animals.Add(new Fox(2, 30, "Песец", 10));
            animals.Add(new Wolf(3, 100, "Волк", 7));

            foreach (Animal animal in animals) {               
                animal.Print();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

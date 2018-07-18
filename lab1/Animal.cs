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
    class Animal
    {

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="weight"></param>
        public Animal(int id, int weight)
        {
            Id = id;
            Weight = weight;

        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Print()
        {

            Console.Write($"id: {Id}, Вес: {Weight} ");

        }


    }
}

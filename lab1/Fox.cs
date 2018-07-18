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
    class Fox : Predator
    {
        /// <summary>
        /// 
        /// </summary>
        public int Count;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="weight"></param>
        /// <param name="type"></param>
        /// <param name="count"></param>
        public Fox(int id, int weight, string type, int count) : base(id, weight, type)
        {
            this.Count = count;
        }
        /// <summary>
        /// 
        /// </summary>
        public override void Print()
        {
            base.Print();

            Console.Write($"Количество: {Count}");
        }
    }
}

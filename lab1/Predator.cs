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
    class Predator : Animal
    {
        /// <summary>
        /// 
        /// </summary>
        public string Type;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="weight"></param>
        /// <param name="type"></param>
        public Predator(int id, int weight, string type):base(id,weight)
        {
            this.Type = type;
        }
        /// <summary>
        /// 
        /// </summary>
        public override void Print()
        {
            base.Print();
            
            string formattedString = string.Format("Тип: {0}, ", Type);
            Console.Write(formattedString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Wolf : Predator
    {
        public int Count;
        public Wolf(int id, int weight, string type, int count) : base(id, weight, type)
        {
            this.Count = count; 
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(Count);
        }
    }
}

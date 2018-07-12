using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Predator : Animal
    {
        public string Type;
        public Predator(int id, int weight, string type):base(id,weight)
        {
            this.Type = type;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(Type);
        }
    }
}

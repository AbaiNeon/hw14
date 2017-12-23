using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw14
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Alex", Age = 28 };
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(person1));
            GC.Collect();
            Console.WriteLine(GC.GetGeneration(person1));

            Console.ReadLine();
        }
    }
}

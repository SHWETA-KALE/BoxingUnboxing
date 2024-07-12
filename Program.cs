using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 23;
            object obj = num;   //implicit  //pass by val=>pass by reference //stack to heap

            num = 1000;

            object obj1 = 67;
            int num2 = (int)obj1;     //explicit //pass by reference => pass by value //heap to stack

            Console.WriteLine(obj);
            Console.WriteLine(num);

            Console.WriteLine(num2);
            Console.WriteLine(obj1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2._1
{
    internal class Program
    {


        static int Value(int number)
        {
            return number + 10;
        }


        static void Main(string[] args)
        {

                Console.WriteLine("введите число");
                int a = int.Parse(Console.ReadLine());

            Console.WriteLine(Value(a));
                Console.ReadKey();  
        }
    }
}



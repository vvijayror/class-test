using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 11;
            int sum = 0;

            while (i<= 15)
            {
           
                sum += i;
                i++;
            }
            Console.WriteLine("sum = {0}", sum);
            Console.ReadLine();
        }
    }
}

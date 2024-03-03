using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class FizzBuzz
    {
        private int _max;

        public FizzBuzz(int max)
        {  _max = max; }

        public void func()
        {
            for (int i = 1; i <= _max; i++)
            {
                if (i % 3 == 0 && i % 5  == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

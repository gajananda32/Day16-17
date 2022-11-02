using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
   public  class Prime
    {
        public void Display()
        {
            bool pr = true;
            int i,j;
            for (i = 2; i <= 1000; i++)
            {
                for (j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        pr = false;
                        break;
                    }
                }
                if (pr)
                {
                    Console.WriteLine(i+": is prime number");
                }
                pr = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in num)
            {
                int j;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {

                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j > Math.Sqrt(i) && i > 1)
                {
                    Console.WriteLine(i + " простое число");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "  четное число");
                }

            }
    }
}

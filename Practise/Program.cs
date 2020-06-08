using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] a = new int[50];
            Console.Write("Enter Decimal Number's: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Decimal Number is: {0}", b);
            for (i = 0; ; i++)
            {
                a[i] = b % 16;
                if (a[i] == 10) a[i] = 65;
                if (a[i] == 11) a[i] = 66;
                if (a[i] == 12) a[i] = 67;
                if (a[i] == 13) a[i] = 68;
                if (a[i] == 14) a[i] = 69;
                if (a[i] == 15) a[i] = 70;
                b = b / 16;
                if (b == 0) break;
            }
            Console.Write("It's Hexa-Decimal Equivalent Number is: ");
            for (j = i; j >= 0; j--)
            {
                if (a[j] == 65 || a[j] == 66 || a[j] == 67 || a[j] == 68 || a[j] == 69 || a[j] == 70)
                {
                    Console.Write(Convert.ToChar(a[j]));
                }
                else
                {
                    Console.Write(a[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("  ********** THE END **********  ");
        }
    }
}

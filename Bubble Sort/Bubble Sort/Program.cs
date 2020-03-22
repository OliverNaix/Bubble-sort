using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Sort
    {
        public static void Check_Bubble(ref int[] digits)
        {
            for (int i = 0; i < digits.Length; i += 1)
            {
                if (i < digits.Length - 1)
                {
                    if (digits[i] > digits[i + 1])
                    {
                        Bubble(ref digits);
                        return;
                    }
                }
            }
        }
        public static void Bubble(ref int[] digits)
        {
            int temp;

            for (int i = 0; i < digits.Length; i += 1)
            {
                if (i < digits.Length - 1)
                {
                    if (digits[i] > digits[i + 1])
                    {
                        temp = digits[i + 1];
                        digits[i + 1] = digits[i];
                        digits[i] = temp;
                    }
                }
            }
            Check_Bubble(ref digits);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[5000];
            Random rnd = new Random();

            for (int i = 0; i < digits.Length; i += 1)
            {
                digits[i] = rnd.Next(0, 10000);
            }
            Sort.Bubble(ref digits);
            foreach (var i in digits)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

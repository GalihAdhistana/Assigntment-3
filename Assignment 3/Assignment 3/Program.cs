using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Please enter your number : ");
            a = int.Parse(Console.ReadLine());

            int[] array = new int[a + 1];
            for (b = 2; b <= a; b++)
            {
                array[b] = 1;
            }
            for (b = 2; b <= a; b++)
            {
                if (array[b] == 1)
                {
                    for (c = 2; c * b <= a; c++)
                    {
                        array[c * b] = 0;
                    }
                }
            }
            Console.Write("The prime numbers are : ");
            for (b = 2; b <= a; b++)
            {
                if (array[b] == 1)
                {
                    Console.Write(b +" ");
                }
            }
        }
    }
}

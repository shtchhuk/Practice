using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal number");
            int decNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter radix");
            int radix = Convert.ToInt32(Console.ReadLine());

            Stack<int> divisionExcesses = new Stack<int>();
            int divresult = decNum / radix;
            int excess = decNum % radix;
            divisionExcesses.Push(excess);
            while (divresult > 0)
            {
                divisionExcesses.Push(divresult % radix);
                divresult /= radix;
            }
            Console.WriteLine(divisionExcesses.Count());
            int size = divisionExcesses.Count();
            Console.WriteLine("Result: ");           
            if (radix <= 10)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(divisionExcesses.Pop());
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (divisionExcesses.Peek() < 10)
                    {
                        Console.Write(divisionExcesses.Pop());
                    }
                    else
                    {
                        Console.Write(toLetter(divisionExcesses.Peek()));
                        divisionExcesses.Pop();
                    }
                }
            }
            Console.ReadKey();
        }
        public static String toLetter(int num)
        {
            switch (num)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                case 16: return "G";
                case 17: return "H";
                case 18: return "I";
                case 19: return "J";
                case 20: return "K";
                default: return "Null";
            }
        }
    }
}

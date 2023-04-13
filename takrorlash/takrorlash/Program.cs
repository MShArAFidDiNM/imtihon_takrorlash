using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter str : ");
            string str = Console.ReadLine();

            Result(str);

            Console.ReadLine();
        }
        public static void Result (string str)
        {
            string[] strarr = str.Split(' ');
            int count = 0;

            for (int i = 0; i < strarr.Length; i++)
            {
                count++;
            }

            Console.WriteLine("Result : " + count);
        }
    }
}

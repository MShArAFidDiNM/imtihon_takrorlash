using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
            result(str);

            Console.ReadLine();
        }
        public static void result (string str)
        {
            string[] arrstr = str.Split(' ');

            for (int i = 0; i < arrstr.Length; i++)
            {
                arrstr[i] = arrstr[i].Substring(0, 1).ToUpper() + arrstr[i].Substring(1);
                Console.Write(arrstr[i]+" ");
            }
          
        }
    }
}

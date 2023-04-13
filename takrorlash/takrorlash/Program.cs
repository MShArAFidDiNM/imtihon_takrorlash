using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace takrorlash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Enter Row : ");
            int row = int.Parse(Console.ReadLine());  
            Console.Write("Enter Col : ");
            int col = int.Parse(Console.ReadLine());
            int[][] arr = new int[row][];

            int sum = 0;
            int count = 0;

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    int RndNumber;
                    RndNumber = rnd.Next(1,10);
                    arr[i][j] = RndNumber;
                    Console.Write(arr[i][j]+"  ");
                    sum += RndNumber;
                    count++;
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Count : " + count);

            bool check = false;
            if (sum >count) check = true;

            Console.WriteLine("Result : " + check);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadachi_20._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> evenStack = new Stack<int>();
            Stack<int> oddStack = new Stack<int>();

            int N = int.Parse(Console.ReadLine());
            Console.Write(" генерирани са ");

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int num = random.Next(1, 102);
                if (num %2 ==0)
                {
                    evenStack.Push(num);
                }
                else
                {
                    oddStack.Push(num);
                }
            }

            Console.Write("Четни числа: ");
            while (evenStack.Count > 0)
            {
                Console.Write(evenStack.Pop() + " ");
            }

            Console.Write("Нечетни числа: ");
            while (oddStack.Count > 0)
            {
                Console.Write(oddStack.Pop() + " ");
            }
        }
    }
}

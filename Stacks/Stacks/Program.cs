using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stacks Problem");
            Console.WriteLine("Choose to perform:\n" +
                " 1. Push\n2. Peek and Pop\n ");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
            switch (num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;

                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.IsEmpty();
                    stack.Pop();
                    stack.Peek();
                    stack.Display();
                    break;

                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
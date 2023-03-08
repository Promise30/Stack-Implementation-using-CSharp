using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_using_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack= new Stack();

            Console.Write("Enter start value: ");
            var _start = int.Parse(Console.ReadLine());

            Console.Write("Enter end value: ");
            var _stop = int.Parse(Console.ReadLine());

            for(var i =_start; i <= _stop; i++)
            {
                stack.Push(i);
            }
            for(var j = _start; j <= _stop; j++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadKey();
        }
    }
}

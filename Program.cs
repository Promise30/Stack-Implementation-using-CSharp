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

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}

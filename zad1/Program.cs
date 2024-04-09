using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();  
            Stack<string> inputS = new Stack<string>();
            Stack<string> stack = new Stack<string>();
            foreach(var item in input)
            {
                inputS.Push(item);
            }
            stack = Reverse(inputS);
            while(stack.Count >1) 
            {
                
                int num1 = int.Parse(stack.Peek());
                stack.Pop();
                char operation = char.Parse(stack.Peek());
                stack.Pop();
                int num2 = int.Parse(stack.Peek());
                stack.Pop();
               
                if(operation == '+')
                {
                    int sum = num1 + num2;
                    stack.Push(sum.ToString());
                }
                else
                {
                    int dif = num1 - num2;
                    stack.Push(dif.ToString());
                }
                
            }
            Console.WriteLine(stack.Pop());
        }
        public static Stack<string> Reverse(Stack<string> stack) 
        {
            Stack<string> help = new Stack<string>();
            while (stack.Count > 0)
            {
                string el = stack.Peek();
                help.Push(el);
                stack.Pop();
            }
            return help;
        }
    }
}

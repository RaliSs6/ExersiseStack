namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i); //индекса на отварящата скоба
                }
                else if (input[i] == ')')
                {
                    int index = stack.Pop(); //връща индекса на последната влязла в стека отваряща скоба
                    Console.WriteLine(input.Substring(index, i - index + 1));

                    //i-index+1  - дължината на подниза
                }
            }
        }
        
    }
}

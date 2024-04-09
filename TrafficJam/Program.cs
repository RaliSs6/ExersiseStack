using System.Text;

namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>();  
            StringBuilder sb = new StringBuilder();
            int cars = 0;
            while(input != "End")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        sb.AppendLine($"{queue.Dequeue()} passed!");
                        cars++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(sb.ToString().TrimEnd());
            Console.WriteLine($"{cars} cars passed the crossroads.");
        }
    }
}

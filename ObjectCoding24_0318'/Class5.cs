using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoding24_0318_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("큐 시뮬레이션을 시작합니다.");
            Console.WriteLine("숫자를 입력하면 큐에 추가(enqueue)됩니다.");
            Console.WriteLine("'d'를 입력하면 큐에서 제거(dequeue)됩니다.");
            Console.WriteLine("'x'를 입력하면 프로그램이 종료됩니다.");

            while (true)
            {
                Console.Write("명령을 입력하세요: ");
                string input = Console.ReadLine();

                if (input == "x")
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }
                else if (input == "d")
                {
                    if (queue.Count == 0)
                    {
                        Console.WriteLine("큐가 비어 있습니다.");
                    }
                    else
                    {
                        int dequeuedItem = queue.Dequeue();
                        Console.WriteLine($"큐에서 제거된 숫자: {dequeuedItem}");
                        DisplayQueue(queue);
                    }
                }
                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        queue.Enqueue(number);
                        Console.WriteLine($"큐에 추가된 숫자: {number}");
                        DisplayQueue(queue);
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 숫자나 'd', 'x'를 입력하세요.");
                    }
                }
            }
        }

        static void DisplayQueue(Queue<int> queue)
        {
            Console.WriteLine("현재 큐 :");
            Console.WriteLine("+---+");

            int[] items = queue.ToArray();
            int rearIndex = items.Length - 1;

            for (int i = rearIndex; i >= 0; i--)
            {
                Console.WriteLine($"| {items[i]} |");
                if (i == queue.Count - 1)
                {
                    Console.WriteLine("  ^");
                }
                if (i == 0)
                {
                    Console.WriteLine("  v");
                }
            }

            Console.WriteLine("+---+");
        }
    }

}



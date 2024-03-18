using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoding24_0318_
{
    using System;
    using System.Collections.Generic;

    class MyStack<T>
    {
        private List<T> items;

        public MyStack()
        {
            items = new List<T>();
        }

        // 스택에 요소를 추가하는 메서드
        public void Push(T item)
        {
            items.Add(item);
        }

        // 스택에서 요소를 제거하고 반환하는 메서드
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("스택이 비어 있습니다.");
            }

            T poppedItem = Peek();
            items.RemoveAt(items.Count - 1);
            return poppedItem;
        }

        // 스택에서 요소를 제거하지 않고 반환하는 메서드
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("스택이 비어 있습니다.");
            }

            return items[items.Count - 1];
        }

        // 스택이 비어 있는지 확인하는 메서드
        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            // 스택에 요소 추가
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // 스택에서 요소 제거하고 출력
            while (!stack.IsEmpty())
            {
                Console.WriteLine("Popped: " + stack.Pop());
            }
        }
    }

}

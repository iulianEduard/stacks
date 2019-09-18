using System;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackWithArray();

            StackWithLinkedList();

            Console.ReadKey();
        }

        static void StackWithArray()
        {
            var withArray = new WithArray(5);

            withArray.Push(2);
            withArray.Push(3);

            withArray.Traverse();

            withArray.Peek();

            withArray.Pop();

            withArray.Push(10);

            withArray.Traverse();
        }

        static void StackWithLinkedList()
        {
            var withLinkedList = new WithLinkedList();

            withLinkedList.Push(20);
            withLinkedList.Push(30);
            withLinkedList.Push(40);
            withLinkedList.Traverse();

            withLinkedList.Pop();
            withLinkedList.Push(50);
            withLinkedList.Push(60);
            withLinkedList.Peek();
            withLinkedList.Traverse();

            withLinkedList.Delete();
            withLinkedList.Traverse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    public class WithLinkedList
    {
        private Node _head;
        private int _size;

        public void Push(int value)
        {
            Console.WriteLine("*** Push ****");

            if (_head == null)
            {
                _head = new Node(value);
            }
            else
            {
                var tempNode = _head;

                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = new Node(value);
            }

            _size++;

            Console.WriteLine($"Node with value: {value} added to stack!");
            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Pop()
        {
            Console.WriteLine("*** Pop ***");

            var tempNode = _head;

            for(int i = 0; i < _size; i++)
            {
                if(i == _size - 2)
                {
                    Console.WriteLine($"Pop out node with value: {tempNode.Next.Value}");
                    tempNode.Next = null;
                    continue;
                }

                tempNode = tempNode.Next;
            }

            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Peek()
        {
            Console.WriteLine("*** Peek ***");

            var tempNode = _head;

            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }

            Console.WriteLine($"Value at peek is: {tempNode.Value}");

            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Delete()
        {
            Console.WriteLine("*** Delete ****");

            _head = null;

            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Traverse()
        {
            Console.WriteLine("*** Traverse stack ***");

            if(!Exists())
            {
                Console.WriteLine("Stack does not exist! Cant performe TRAVERSE operation!");
                return;
            }

            var tempNode = _head;

            do
            {
                Console.WriteLine($"Node value: {tempNode.Value}");
                tempNode = tempNode.Next;
            }
            while (tempNode != null);

            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        private bool Exists()
        {
            return _head != null ? true : false;
        }
    }
}

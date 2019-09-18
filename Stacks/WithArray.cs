using System;

namespace Stacks
{
    public class WithArray
    {
        private readonly int _stackCapacity = 0;
        private int _topOfStack = -1;
        private int[] _stack;

        public WithArray(int length)
        {
            _stack = new int[length];
            _stackCapacity = length;
        }

        public void Push(int value)
        {
            Console.WriteLine("*** Push ***");

            if(CheckIfFull())
            {
                Console.WriteLine("Stack is full. Cannot perform PUSH operation!");
                return;
            }

            _stack[_topOfStack + 1] = value;
            _topOfStack++;

            Console.WriteLine($"Value: {value} was added to stack");
            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Pop()
        {
            Console.WriteLine("*** Pop ****");

            if(CheckIfEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot perform POP operation!");
                return;
            }

            var valueToRemove = _stack[_topOfStack];
            Console.WriteLine($"Pop out value: {valueToRemove}");

            _stack[_topOfStack] = 0;
            _topOfStack--;

            Console.WriteLine($"Value: {valueToRemove} was pop out of stack!");
            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Peek()
        {
            Console.WriteLine("*** Peek ***");

            if (CheckIfEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot perform PEEK operation!");
                return;
            }

            var peekResult = _stack[_topOfStack];

            Console.WriteLine($"Peek value: {peekResult}");
            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Delete()
        {
            Console.WriteLine("*** Delete ***");

            _stack = null;

            Console.WriteLine("Stack deleted");
            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        public void Traverse()
        {
            Console.WriteLine("*** Traverse ***");

            if(CheckIfEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot perform traverse operation!");
                return;
            }

            Console.WriteLine("Stack stored data:");
            for(int i = 0; i < _stackCapacity; i++)
            {
                Console.WriteLine($"--> Position: {i}, value: {_stack[i]}");
            }

            Console.WriteLine("EOF");
            Console.WriteLine("");
        }

        private bool CheckIfFull()
        {
            return _stackCapacity == _topOfStack ? true : false;
        }

        private bool CheckIfEmpty()
        {
            return _topOfStack == -1 ? true : false;
        }

    }
}

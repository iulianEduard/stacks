namespace Stacks
{
    public class Node
    {
        private int _value;

        public Node Next { get; set; }

        public int Value
        {
            get => _value;
            set => _value = value;
        }

        public Node(int value)
        {
            Value = value;
        }
    }
}

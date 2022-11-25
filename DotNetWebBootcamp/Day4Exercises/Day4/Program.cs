namespace Day4
{
    internal class Program
    {
        // data structure
        int[] ints = new int[] { 1,3};
        static LinkedList<int> _list = new LinkedList<int>();
        static Stack<int> _stack = new Stack<int>();
        static Queue<int> _queue = new Queue<int>();

        static void Main(string[] args)
        {
            _stack.Push(0);
            _queue.Enqueue(0);
            _list.AddFirst(0);

        }
    }
}
namespace DS
{
    public class Stack<T>
    {
        private int _top;
        private T[] _stackArray;
        public Stack()
        {
            _top = -1;
            _stackArray = new T[100];
        }
        public void Clear() => _top = -1;
        public void Push(T value) => _stackArray[++_top] = value;
        public T Pop() => _stackArray[_top--];
        public T Top { get => _stackArray[_top]; }
        public bool IsEmpty { get => _top == -1 ? true : false; }

    }
}

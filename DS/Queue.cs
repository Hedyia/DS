namespace DS
{
    class Queue<T>
    {
        private int _front;
        private int _rear;
        private T[] _arrQueue;
        public Queue()
        {
            _front = -1;
            _rear = -1;
            _arrQueue = new T[100];
        }

        public void Eequeue(T value) => _arrQueue[++_rear] = value;
        public T Dequeue() => _arrQueue[++_front];
        public bool IsEmpty { get => _front == _rear; }
        public T Front { get => _arrQueue[_front + 1]; }
    }
}

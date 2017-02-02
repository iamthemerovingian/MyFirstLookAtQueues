namespace MyFirstLookAtQueues
{
    class QueueArray<T>
    {
        private T[] _array = new T[0];

        private int _head = 0;
        private int _tail = 0;

        private int _size = 0;

        public void Queue(T item)
        {
            if (_size == _array.Length)
            {
                int newLength = _size == 0 ? 4 : _size * 2;

                T[] temp = new T[newLength];
                if (_head > _tail)
                {
                    _array.CopyTo(temp, 0);
                    _array = temp;
                }

            }

            _array[_size] = item;
            _size++;
            _head++;
        }

        public T DeQueue()
        {
            if (_size == 0)
            {
                throw new System.Exception("Out items to dequeue.");
            }

            T temp = _array[_head];
            _head++;
            _size--;

            return temp;
        }
    }
}

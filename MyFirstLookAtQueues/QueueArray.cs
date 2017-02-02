
namespace MyFirstLookAtQueues
{
    class QueueArray<T> : System.Collections.Generic.IEnumerable<T>
    {
        private T[] _array = new T[0];

        private int _head = 0;
        private int _tail = -1;

        private int _size = 0;

        public void AddtoQueue(T item)
        {

            if (_size == _array.Length)
            {
                int targetIndex = 0;

                int newLength = _size == 0 ? 4 : _size * 2;
                T[] temp = new T[newLength];

                if (_size > 0)
                {
                   if (_tail < _head)
                    {
                        //Copy from head to the end of the array.
                        for (int i = _head; i < _array.Length; i++)
                        {
                            temp[targetIndex] = _array[i];
                            targetIndex++;
                        }
                        //copy from begening to tail
                        for (int i = 0; i <= _tail; i++)
                        {
                            temp[targetIndex] = _array[i];
                        }

                    }
                    else// Then the head is at the front of the array and the tail is at the end, so normal copying will suffice.
                    {
                        for (int i = 0; i <= _tail; i++)
                        {
                            temp[targetIndex] = temp[i];
                            targetIndex++;
                        }
                    }
                    _head = 0;
                    _tail = targetIndex -1;
                }
                else
                {
                    _head = 0;
                    _tail = -1;
                }
                
                _array = temp;

            }

            //Add the new item to the array.
            if (_tail == _array.Length -1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }

            _array[_tail] = item;
            _size++;
        }

        public T DeQueue()
        {
            if (_size == 0)
            {
                throw new System.Exception("Out items to dequeue.");
            }

            T temp = _array[_head];

            //wrap the head
            if (_head == _array.Length - 1)
            {
                _head = 0;
            }
            else
            {
                _head++;
            }

            _size--;

            System.Console.WriteLine(temp);
            return temp;
        }

        public void Clear()
        {
            _head = 0;
            _tail = -1;
            _size = 0;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            if (_tail < _head)
            {
                // head to end.
                for (int i = _head; i < _array.Length; i++)
                {
                    yield return _array[i];
                }

                //0 to tail.
                for (int i = 0; i < _tail; i++)
                {
                    yield return _array[i];
                }
            }
            else
            {
                //Head to tail.
                for (int i = 0; i < _array.Length; i++)
                {
                    yield return _array[i];
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

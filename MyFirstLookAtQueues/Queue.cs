

namespace MyFirstLookAtQueues
{
    class Queue<T> : System.Collections.Generic.IEnumerable<T>
    {
        private System.Collections.Generic.LinkedList<T> _list = new System.Collections.Generic.LinkedList<T>();

        public void AddtoQueue(T item)
        {
            _list.AddLast(item);
        }

        public T DeQueue()
        {
            if (_list.Count== 0)
            {
                throw new System.Exception("There are no more items in the Queue");
            }

            T temp = _list.First.Value;
            _list.RemoveFirst();
            System.Console.WriteLine(temp);
            return temp;
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)_list).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.Generic.IEnumerable<T>)_list).GetEnumerator();
        }
    }
}

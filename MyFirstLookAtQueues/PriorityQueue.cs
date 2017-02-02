
namespace MyFirstLookAtQueues
{
    public class PriorityQueue<T> : Queue<T> where T: System.IComparable<T>
    {
        public override void AddtoQueue(T item)
        {
            if (_list.Count == 0)
            {
                _list.AddLast(item);
            }
            else
            {
                //if the value is greater than the current value add before the current value.
                var current = _list.First;

                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    _list.AddLast(item);
                }
                else
                {
                    _list.AddBefore(current, item);
                }

            }
        }
    }
}

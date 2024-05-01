using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_System.Classes
{
    public class Queue_Implementation<T>
    {
        private readonly List<T> _items;

        public Queue_Implementation()
        {
            _items = new List<T>();
        }

        public int Count => _items.Count;

        public bool IsEmpty => _items.Count == 0;

        public void Enqueue(T item)
        {
            _items.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = _items[0];
            _items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return _items[0];
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public List<T> GetAllElements()
        {
            // Create a new list to avoid modifying the internal queue
            return new List<T>(_items);
        }
    }
}

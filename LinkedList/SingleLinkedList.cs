using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliTamim.LinkedList
{
    public class SingleLinkedList<T> : ICollection<T>
    {
        private ChainNode<T>? _head;
        private ChainNode<T>? _tail;

        #region Add
        public void AddFirst(T value)
        {
            AddFirst(new ChainNode<T>(value));
        }
        public void AddFirst(ChainNode<T> node)
        {
            ChainNode<T>? temp = _head;
            _head = node;
            _head.Next = temp;
            Count++;
            if(Count == 1)
            {
                _tail = _head;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new ChainNode<T>(value));
        }
        public void AddLast(ChainNode<T> node)
        {
            if(Count == 0)
            {
                _head = node;
            } else
            {
                _tail.Next = node;
            }
            _tail = node;
            Count++;
        }
        #endregion

        #region remove
        #endregion

        #region ICollection
        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

using System.Collections;

namespace AliTamim.LinkedList
{
    public class DoubleLinkedList<T> : ICollection<T>
    {
        private DoubleLinkedListNode<T>? _head;
        private DoubleLinkedListNode<T>? _tail;

        #region Add
        public void AddFirst(T value)
        {
            AddFirst(new DoubleLinkedListNode<T>(value));
        }
        public void AddFirst(DoubleLinkedListNode<T> node)
        {
            DoubleLinkedListNode<T>? temp = _head;
            _head = node;
            _head.Next = temp;
            Count++;
            if(Count == 1)
            {
                _tail = _head;
            } else
            {
                temp.Previous = _head;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new DoubleLinkedListNode<T>(value));
        }
        public void AddLast(DoubleLinkedListNode<T> node)
        {
            if(Count == 0)
            {
                _head = node;
            } else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }
            _tail = node;
            Count++;
        }
        #endregion

        #region remove
        public void RemoveFirst()
        {
            if (Count > 0)
            {
                _head = _head.Next;
                Count--;

                if (Count == 0)
                {
                    _tail = null;
                } else
                {
                    _head.Previous = null;
                }
            }
        }
        public void RemoveLast()
        {
            if (Count > 0)
            {
                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                } else
                {
                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;
                }
                Count--;
            } 
        }
        #endregion

        #region ICollection
        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            DoubleLinkedListNode<T> current = _head;
            while(current != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            DoubleLinkedListNode<T> current = _head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoubleLinkedListNode<T> cureent = _head;
            while (cureent != null)
            {
                yield return cureent.Value;
                cureent = cureent.Next;
            }
        }

        public bool Remove(T item)
        {
            DoubleLinkedListNode<T> previous = null;
            DoubleLinkedListNode<T> cureent = _head;
            // 1- empty list: do nothing
            // 2- single node: previous = null;
            // many node::
            //  a- node to remove is the first node
            //  b- node to remove is the middle or last

            while(cureent != null)
            {
                if(cureent.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = cureent.Next;
                        if (cureent.Next == null)
                        {
                            _tail = previous;
                        } else
                        {
                            cureent.Next.Previous = previous;
                        }
                        Count--;
                    } else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = cureent;
                cureent = cureent.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}


namespace AliTamim.LinkedList
{
    public class DoubleLinkedListNode<T>
    {
        public T Value { get; private set; }
        public DoubleLinkedListNode<T>? Next { get; set; }
        public DoubleLinkedListNode<T>? Previous { get; set; }

        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
    }
}

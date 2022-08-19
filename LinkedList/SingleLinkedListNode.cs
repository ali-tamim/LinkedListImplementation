
namespace AliTamim.LinkedList
{
    public class SingleLinkedListNode<T>
    {
        public T Value { get; private set; }
        public SingleLinkedListNode<T>? Next { get; set; }

        public SingleLinkedListNode(T value)
        {
            Value = value;
        }
    }
}


namespace AliTamim.LinkedList
{
    public class ChainNode<T>
    {
        public T Value { get; set; }
        public ChainNode<T>? Next { get; set; }

        public ChainNode(T value)
        {
            Value = value;
        }
    }
}

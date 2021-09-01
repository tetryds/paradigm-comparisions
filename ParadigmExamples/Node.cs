namespace ParadigmExamples
{
    public sealed class Node<T>
    {
        public readonly T Element;
        public Node<T> Next;

        public Node(T element, Node<T> next)
        {
            Element = element;
            Next = next;
        }
    }
}

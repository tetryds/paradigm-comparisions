using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmExamples
{
    public class LinkedList<T>
    {
        Node<T> First;
        public int Count = 0;

        public T this[int index]
        {
            get
            {
                return ElementAt(index);
            }
        }

        public T ElementAt(int index)
        {
            CheckIndexGet(index);

            Node<T> current = First;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Element;
        }

        public void ForEach(Action<T> action)
        {
            Node<T> current = First;
            while (current != null)
            {
                action?.Invoke(current.Element);
                current = current.Next;
            }
        }

        public int IndexOf(T element)
        {
            int index = 0;
            Node<T> current = First;

            while (current != null && !Equals(current.Element, element))
            {
                index++;
                current = current.Next;
            }

            return current != null && Equals(current.Element, element) ? index : -1;
        }

        public void AddAt(int index, T element)
        {
            CheckIndexInsert(index);

            Node<T> previous = null;
            Node<T> current = First;
            for (int i = 0; i < index; i++)
            {
                previous = current;
                current = current?.Next;
            }

            Node<T> newNode = new Node<T>(element, current);
            if (previous == null)
                First = newNode;
            else
                previous.Next = newNode;
            Count++;
        }

        public void AddFirst(T element) => AddAt(0, element);
        public void AddLast(T element) => AddAt(Count, element);

        public void AddAfter(T previous, T element)
        {
            int index = IndexOf(previous);
            if (index == -1)
                throw new Exception($"Cannot add after element not present on the linked list: '{previous}'");
            index++;
            AddAt(index, element);
        }

        public T RemoveAt(int index)
        {
            if (First == null)
                throw new Exception("Cannot remove first because linked list is empty");
            CheckIndexGet(index);

            Node<T> previous = null;
            Node<T> current = First;

            for (int i = 0; i < index; i++)
            {
                previous = current;
                current = current.Next;
            }

            if (previous == null)
                First = current.Next;
            else
                previous.Next = current.Next;

            Count--;
            return current.Element;
        }

        public T RemoveFirst() => RemoveAt(0);
        public T RemoveLast() => RemoveAt(Count - 1);

        public bool Remove(T element)
        {
            int index = IndexOf(element);
            if (index == -1)
                return false;

            RemoveAt(index);
            return true;
        }

        private void CheckIndexInsert(int index)
        {
            if (index < 0 || index > Count)
                throw new IndexOutOfRangeException($"Index {index} is out of range");
        }

        private void CheckIndexGet(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException($"Index {index} is out of range");
        }
    }
}

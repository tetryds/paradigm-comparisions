using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmExamples
{
    public static class LinkedListFuncs
    {
        public static int Count<T>(Node<T> first)
        {
            int count = 0;
            Node<T> current = first;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public static Node<T> Find<T>(Node<T> first, T element)
        {
            Node<T> current = first;
            while (current != null && !Equals(current.Element, element))
            {
                current = current.Next;
            }
            return current;
        }

        public static void Insert<T>(ref Node<T> current, T element)
        {
            Node<T> newNode = new Node<T>(element, current?.Next);
            if (current == null)
                current = newNode;
            else
                current.Next = newNode;
        }

        public static void AddFirst<T>(ref Node<T> first, T element)
        {
            Node<T> newNode = new Node<T>(element, first);
            first = newNode;
        }

        public static void AddLast<T>(ref Node<T> first, T element)
        {
            if (first == null)
                Insert(ref first, element);
            else
            {
                Node<T> last = GetLast(first);
                Insert(ref last, element);
            }
        }

        public static Node<T> GetLast<T>(Node<T> first)
        {
            if (first == null) return first;

            Node<T> current = first;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        public static T RemoveFirst<T>(ref Node<T> first)
        {
            if (first == null)
                throw new Exception("Cannot remove first element of empty list");
            T element = first.Element;
            first = first.Next;
            return element;
        }

        public static T RemoveLast<T>(ref Node<T> first)
        {
            if (first == null)
                throw new Exception("Cannot remove last element of empty list");

            Node<T> previous = null;
            Node<T> current = first;
            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            if (previous == null)
                first = null;
            else
                previous.Next = null;

            return current.Element;
        }

        public static bool Remove<T>(ref Node<T> first, T element)
        {
            if (first == null)
                return false;

            if (Equals(first.Element, element))
            {
                first = first.Next;
                return true;
            }

            Node<T> previous = null;
            Node<T> current = first;
            while (current != null && !Equals(current.Element, element))
            {
                previous = current;
                current = current.Next;
            }

            if (current == null)
                return false;

            previous.Next = current.Next;
            return true;
        }
    }
}

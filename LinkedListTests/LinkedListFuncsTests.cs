using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParadigmExamples;
using static ParadigmExamples.LinkedListFuncs;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListFuncsTests
    {
        [TestMethod]
        public void TestAddFirst()
        {
            Node<int> first = null;

            AddFirst(ref first, 5);
            AddFirst(ref first, 4);
            AddFirst(ref first, 3);
            AddFirst(ref first, 2);
            AddFirst(ref first, 1);
            AddFirst(ref first, 0);

            List<int> expected = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            AddResults(first, results);

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAddLast()
        {
            Node<int> first = null;

            AddLast(ref first, 0);
            AddLast(ref first, 1);
            AddLast(ref first, 2);
            AddLast(ref first, 3);
            AddLast(ref first, 4);
            AddLast(ref first, 5);

            List<int> expected = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            AddResults(first, results);

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestFind()
        {
            Node<int> first = null;

            AddFirst(ref first, 5);
            AddFirst(ref first, 4);
            AddFirst(ref first, 3);
            AddFirst(ref first, 2);
            AddFirst(ref first, 1);
            AddFirst(ref first, 0);

            Assert.AreEqual(Find(first, 0), first);
            Assert.AreEqual(Find(first, 1), first.Next);
            Assert.AreEqual(Find(first, 2), first.Next.Next);
            Assert.AreEqual(Find(first, 3), first.Next.Next.Next);
            Assert.AreEqual(Find(first, 4), first.Next.Next.Next.Next);
            Assert.AreEqual(Find(first, 5), first.Next.Next.Next.Next.Next);
            Assert.AreEqual(Find(first, 6), null);
        }

        [TestMethod]
        public void TestAddAt()
        {
            Node<int> first = null;

            AddLast(ref first, 0);
            AddLast(ref first, 1);
            AddLast(ref first, 2);
            AddLast(ref first, 3);
            AddLast(ref first, 4);
            AddLast(ref first, 5);

            Node<int> third = Find(first, 3);
            Insert(ref third, 6);

            List<int> expected = new List<int> { 0, 1, 2, 3, 6, 4, 5 };
            List<int> results = new List<int>();

            AddResults(first, results);

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestCount()
        {
            Node<int> first = null;

            Assert.AreEqual(Count(first), 0);
            AddLast(ref first, 0);
            Assert.AreEqual(Count(first), 1);
            AddLast(ref first, 1);
            Assert.AreEqual(Count(first), 2);
            AddLast(ref first, 2);
            Assert.AreEqual(Count(first), 3);
            AddLast(ref first, 3);
            Assert.AreEqual(Count(first), 4);
            AddLast(ref first, 4);
            Assert.AreEqual(Count(first), 5);
            AddLast(ref first, 5);
            Assert.AreEqual(Count(first), 6);
            RemoveLast(ref first);
            Assert.AreEqual(Count(first), 5);
        }

        [TestMethod]
        public void TestGetLast()
        {
            Node<int> first = null;
            Node<int> last;

            last = GetLast(first);
            Assert.AreEqual(first, last);
            Assert.IsNull(last);

            AddLast(ref first, 0);
            last = GetLast(first);
            Assert.AreEqual(first, last);

            AddLast(ref first, 1);
            last = GetLast(first);
            Assert.AreEqual(first.Next, last);

            AddLast(ref first, 2);
            last = GetLast(first);
            Assert.AreEqual(first.Next.Next, last);

            AddLast(ref first, 3);
            last = GetLast(first);
            Assert.AreEqual(first.Next.Next.Next, last);

            AddLast(ref first, 4);
            last = GetLast(first);
            Assert.AreEqual(first.Next.Next.Next.Next, last);

            AddLast(ref first, 5);
            last = GetLast(first);
            Assert.AreEqual(first.Next.Next.Next.Next.Next, last);
        }

        [TestMethod]
        public void TestRemoveFirst()
        {
            Node<int> first = null;

            AddFirst(ref first, 5);
            AddFirst(ref first, 4);
            AddFirst(ref first, 3);
            AddFirst(ref first, 2);
            AddFirst(ref first, 1);
            AddFirst(ref first, 0);

            List<int> expected = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            AddResults(first, results);
            int current;

            CollectionAssert.AreEqual(expected, results);

            int count = expected.Count;
            for (int i = 0; i < count; i++)
            {
                results.Clear();

                current = RemoveFirst(ref first);
                Assert.AreEqual(expected[0], current);
                expected.RemoveAt(0);
                AddResults(first, results);

                CollectionAssert.AreEqual(expected, results);
            }

            Assert.IsNull(first);
        }

        [TestMethod]
        public void TestRemoveLast()
        {
            Node<int> first = null;

            AddFirst(ref first, 5);
            AddFirst(ref first, 4);
            AddFirst(ref first, 3);
            AddFirst(ref first, 2);
            AddFirst(ref first, 1);
            AddFirst(ref first, 0);

            List<int> expected = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            AddResults(first, results);
            int current;

            CollectionAssert.AreEqual(expected, results);

            int count = expected.Count;
            for (int i = 0; i < count; i++)
            {
                results.Clear();

                current = RemoveLast(ref first);
                Assert.AreEqual(expected[expected.Count - 1], current);
                expected.RemoveAt(expected.Count - 1);
                AddResults(first, results);

                CollectionAssert.AreEqual(expected, results);
            }

            Assert.IsNull(first);
        }

        [TestMethod]
        public void TestRemove()
        {
            Node<int> first = null;

            AddFirst(ref first, 5);
            AddFirst(ref first, 4);
            AddFirst(ref first, 3);
            AddFirst(ref first, 2);
            AddFirst(ref first, 1);
            AddFirst(ref first, 0);

            Remove(ref first, 1);
            Remove(ref first, 3);
            Remove(ref first, 0);

            List<int> expected = new List<int> { 2, 4, 5 };
            List<int> results = new List<int>();

            AddResults(first, results);

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemoveSingle()
        {
            Node<int> first = null;

            AddFirst(ref first, 0);

            Remove(ref first, 0);

            List<int> expected = new List<int> { };
            List<int> results = new List<int>();

            AddResults(first, results);

            Assert.IsNull(first);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemoveAll()
        {
            Node<int> first = null;

            AddFirst(ref first, 2);
            AddFirst(ref first, 1);
            AddFirst(ref first, 0);

            Remove(ref first, 0);
            Remove(ref first, 1);
            Remove(ref first, 2);

            List<int> expected = new List<int> {  };
            List<int> results = new List<int>();

            AddResults(first, results);

            Assert.IsNull(first);
            CollectionAssert.AreEqual(expected, results);
        }

        private static void AddResults(Node<int> first, List<int> results)
        {
            Node<int> current = first;
            while (current != null)
            {
                results.Add(current.Element);
                current = current.Next;
            }
        }
    }
}

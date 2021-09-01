using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParadigmExamples;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestAddFirst()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(0);
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);

            List<int> expected = new List<int> { 5, 4, 3, 2, 1, 0 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAddLast()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddLast(0);
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            List<int> expected = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAddAt()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            linkedList.AddAt(2, 6);
            linkedList.AddAt(4, 7);
            linkedList.AddAt(6, 8);

            List<int> expected = new List<int> { 0, 1, 6, 2, 7, 3, 8, 4, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestAddAfter()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            linkedList.AddAfter(2, 6);
            linkedList.AddAfter(4, 7);

            List<int> expected = new List<int> { 0, 1, 2, 6, 3, 4, 7, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemove()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            bool removeFirst = linkedList.Remove(4);
            bool removeSecond = linkedList.Remove(2);

            List<int> expected = new List<int> { 0, 1, 3, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            Assert.IsTrue(removeFirst);
            Assert.IsTrue(removeSecond);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemoveLast()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            int last = linkedList.RemoveLast();

            List<int> expected = new List<int> { 0, 1, 2, 3, 4 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            Assert.AreEqual(5, last);
            Assert.AreEqual(expected.Count, results.Count);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemoveFirst()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            int first = linkedList.RemoveFirst();

            List<int> expected = new List<int> { 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            Assert.AreEqual(0, first);
            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemoveAtIndex()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            int removed = linkedList.RemoveAt(3);

            List<int> expected = new List<int> { 0, 1, 2, 4, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestRemoveNotPresent()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            bool removed = linkedList.Remove(6);

            Assert.IsFalse(removed);
        }

        [TestMethod]
        public void TestRemoveAll()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            linkedList.RemoveFirst();
            linkedList.RemoveFirst();
            linkedList.RemoveFirst();
            linkedList.RemoveFirst();
            linkedList.RemoveFirst();
            linkedList.RemoveFirst();

            List<int> expected = new List<int> { };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(i));

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestIndexOf()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            List<int> expected = new List<int> { 0, 1, 2, 3, 4, 5 };
            List<int> results = new List<int>();

            linkedList.ForEach(i => results.Add(linkedList.IndexOf(i)));

            int notPresentIndex = linkedList.IndexOf(6);
            Assert.AreEqual(-1, notPresentIndex);

            CollectionAssert.AreEqual(expected, results);
        }

        [TestMethod]
        public void TestElementAt()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            Assert.AreEqual(0, linkedList.ElementAt(0));
            Assert.AreEqual(1, linkedList.ElementAt(1));
            Assert.AreEqual(2, linkedList.ElementAt(2));
            Assert.AreEqual(3, linkedList.ElementAt(3));
            Assert.AreEqual(4, linkedList.ElementAt(4));
            Assert.AreEqual(5, linkedList.ElementAt(5));

            Assert.AreEqual(0, linkedList[0]);
            Assert.AreEqual(1, linkedList[1]);
            Assert.AreEqual(2, linkedList[2]);
            Assert.AreEqual(3, linkedList[3]);
            Assert.AreEqual(4, linkedList[4]);
            Assert.AreEqual(5, linkedList[5]);
        }

        [TestMethod]
        public void TestExceptions()
        {
            ParadigmExamples.LinkedList<int> linkedList = new ParadigmExamples.LinkedList<int>();

            Assert.ThrowsException<IndexOutOfRangeException>(() => linkedList.AddAt(6, 6));
            Assert.ThrowsException<Exception>(() => linkedList.AddAfter(6, 6));

            linkedList.AddFirst(5);
            linkedList.AddFirst(4);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(0);

            Assert.ThrowsException<IndexOutOfRangeException>(() => linkedList.ElementAt(6));
            Assert.ThrowsException<IndexOutOfRangeException>(() => linkedList[6]);
            Assert.ThrowsException<IndexOutOfRangeException>(() => linkedList.RemoveAt(6));
        }
    }
}

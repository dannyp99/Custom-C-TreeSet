using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TreeSetTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var sample = new TreeSet<int>(new HashSet<int>());
            Console.WriteLine(sample.set.Count);
            Assert.AreEqual(sample.set.Count, 0);
        }
    }
}
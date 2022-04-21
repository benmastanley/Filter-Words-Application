using CalastoneApplicationLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace CalastoneApplicationTest
{
    /// <summary>
    /// Test suite for <see cref="FilterService"/>
    /// </summary>
    public class Tests
    {
        [Test]
        public void FilterMiddleVowels_SuccessfullyHandlesList()
        {
            var sut = new FilterService();
            var originalList = new List<string> 
            {
                "hello", "table", "orange", "television", "which", "fair", "add"
            };
            var newList = sut.FilterMiddleVowels(originalList);
            Assert.True(newList.Contains("hello"));
            Assert.True(newList.Contains("table"));
            Assert.False(newList.Contains("orange"));
            Assert.False(newList.Contains("television"));
            Assert.False(newList.Contains("which"));
            Assert.False(newList.Contains("fair"));
            Assert.True(newList.Contains("add"));
        }

        [Test]
        public void FilterMiddleVowels_EmptyList()
        {
            var sut = new FilterService();
            var originalList = new List<string>();
            var newList = sut.FilterMiddleVowels(originalList);
            Assert.AreEqual(originalList.Count, newList.Count);
            Assert.IsEmpty(newList);
        }

        [Test]
        public void FilterMiddleVowels_HandlesNull()
        {
            var sut = new FilterService();
            var newList = sut.FilterMiddleVowels(null);
            Assert.IsEmpty(newList);
        }


        [Test]
        public void FilterLengthLessThanThree_SuccessfullyHandlesList()
        {
            var sut = new FilterService();
            var originalList = new List<string>
            {
                "hello", "to", "orange", "me", "which", "fair", "go"
            };
            var newList = sut.FilterLengthLessThanThree(originalList);
            Assert.True(newList.Contains("hello"));
            Assert.False(newList.Contains("to"));
            Assert.True(newList.Contains("orange"));
            Assert.False(newList.Contains("me"));
            Assert.True(newList.Contains("which"));
            Assert.True(newList.Contains("fair"));
            Assert.False(newList.Contains("go"));
        }

        [Test]
        public void FilterLengthLessThanThree_EmptyList()
        {
            var sut = new FilterService();
            var originalList = new List<string>();
            var newList = sut.FilterLengthLessThanThree(originalList);
            Assert.AreEqual(originalList.Count, newList.Count);
            Assert.IsEmpty(newList);
        }

        [Test]
        public void FilterLengthLessThanThree_HandlesNull()
        {
            var sut = new FilterService();
            var newList = sut.FilterLengthLessThanThree(null);
            Assert.IsEmpty(newList);
        }


        [Test]
        public void FilterWordsContainingLetterT_SuccessfullyHandlesList()
        {
            var sut = new FilterService();
            var originalList = new List<string>
            {
                "hello", "to", "orange", "table", "smart", "fair", "there"
            };
            var newList = sut.FilterWordsContainingLetterT(originalList);
            Assert.True(newList.Contains("hello"));
            Assert.False(newList.Contains("to"));
            Assert.True(newList.Contains("orange"));
            Assert.False(newList.Contains("table"));
            Assert.False(newList.Contains("smart"));
            Assert.True(newList.Contains("fair"));
            Assert.False(newList.Contains("there"));
        }

        [Test]
        public void FilterWordsContainingLetterT_EmptyList()
        {
            var sut = new FilterService();
            var originalList = new List<string>();
            var newList = sut.FilterWordsContainingLetterT(originalList);
            Assert.AreEqual(originalList.Count, newList.Count);
            Assert.IsEmpty(newList);
        }

        [Test]
        public void FilterWordsContainingLetterT_HandlesNull()
        {
            var sut = new FilterService();
            var newList = sut.FilterWordsContainingLetterT(null);
            Assert.IsEmpty(newList);
        }
    }
}
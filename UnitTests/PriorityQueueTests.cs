using ChoresFinalProject;
using System;
using Xunit;
namespace UnitTests
{
    public class PriorityQueueTests
    {
        [Fact] //test to see if queue is empty
        public void testPriorityQueueIsEmpty() {
            PriorityQueue a = new PriorityQueue();

            Assert.True(a.isQueueEmpty());
        }

        [Fact]
        public void testPrioritySize() {
            int expected = 2;
            PriorityQueue a = new PriorityQueue();
            a.enqueue("Dishes", 1.5, 'D');
            a.enqueue("Mow", 2, 'A');

            Assert.Equal(expected, a.queueSize());
        }

        [Fact]
        public void testPrioritySizeNotEqual()
        {
            int expected = 1;
            PriorityQueue a = new PriorityQueue();
            a.enqueue("Dishes", 1.5, 'D');
            a.enqueue("Mow", 2, 'A');

            Assert.NotEqual(expected, a.queueSize());
        }

    }
}

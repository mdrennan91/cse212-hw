using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them
    // Expected Result: The item with the highest priority is dequeued first
    // Defect(s) Found: The highest priority item was not being correctly dequeued due to a faulty loop condition.
    // Fix: Corrected the loop in the Dequeue method to make sure all elements are properly checked.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 2);
        priorityQueue.Enqueue("Task2", 5);
        priorityQueue.Enqueue("Task3", 3);

        Assert.AreEqual("Task2", priorityQueue.Dequeue());
        Assert.AreEqual("Task3", priorityQueue.Dequeue());
        Assert.AreEqual("Task1", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with the same priority (Task1, Task2, Task3 all with priority 2).
    // Expected Result: The items should be dequeued in the order they were added (Task1, Task2, Task3).
    // Defect(s) Found: Items with the same priority were not being dequeued in FIFO order. This was due to incorrect indexing during dequeue.
    // Fix: Adjusted the `Dequeue` method to prioritize the first element when priorities are equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task1", 2);
        priorityQueue.Enqueue("Task2", 2);
        priorityQueue.Enqueue("Task3", 2);

        Assert.AreEqual("Task1", priorityQueue.Dequeue());
        Assert.AreEqual("Task2", priorityQueue.Dequeue());
        Assert.AreEqual("Task3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: An exception is thrown
    // Defect(s) Found: The code was not throwing an exception when trying to dequeue from an empty queue.
    // Fix: Added a check to throw `InvalidOperationException` if the queue is empty.
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
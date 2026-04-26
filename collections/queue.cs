/*
QUEUE in c#
A queue is a data structure that follows the First In First Out (FIFO) principle.
It is like a line of people waiting for a service, where the first person in line is the first one to be served.


| Method       | Use                   |
| ------------ | --------------------- |
| `Enqueue(x)` | Add                   |
| `Dequeue()`  | Remove & return front |
| `Peek()`     | View front            |
| `Count`      | Size                  |
| `Clear()`    | Remove all            |

*/

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(1); // Queue: [1]
        queue.Enqueue(2); // Queue: [1, 2]
        queue.Enqueue(3); // Queue: [1, 2, 3]

        Console.WriteLine("Front element: " + queue.Peek()); // Output: 1
        Console.WriteLine("Queue size: " + queue.Count); // Output: 3

        Console.WriteLine("Dequeued element: " + queue.Dequeue()); // Output: 1, Queue: [2, 3]
        Console.WriteLine("Front element after dequeue: " + queue.Peek()); // Output:
        Console.WriteLine("Queue size after dequeue: " + queue.Count); // Output: 2

        queue.Clear(); // Queue is now empty
        Console.WriteLine("Queue size after clear: " + queue.Count); // Output:

    }
}
/*
STACK in C#
    A stack is a linear data structure that follows the Last In First Out (LIFO) principle. 
    It is like a stack of plates where you can only add or remove the top plate.


| Method    | Use                 |
| --------- | ------------------- |
| `Push(x)` | Add                 |
| `Pop()`   | Remove & return top |
| `Peek()`  | View top            |
| `Count`   | Size                |
| `Clear()` | Remove all          |

*/

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(1); // Stack: [1]
        stack.Push(2); // Stack: [1, 2]
        stack.Push(3); // Stack: [1, 2, 3]

        Console.WriteLine("Top element: " + stack.Peek()); // Output: 3
        Console.WriteLine("Stack size: " + stack.Count); // Output: 3

        Console.WriteLine("Popped element: " + stack.Pop()); // Output: 3, Stack: [1, 2]
        Console.WriteLine("Top element after pop: " + stack.Peek()); // Output:
        Console.WriteLine("Stack size after pop: " + stack.Count); // Output: 2

        stack.Clear(); // Stack is now empty
        Console.WriteLine("Stack size after clear: " + stack.Count); // Output: 0
    }
}


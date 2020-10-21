# Stacks and Queues

*Author: Peyton Cysewski*

---

## Description

A Java implementation of a `Stack` and `Queue`. Stacks and Queues both contain individual nodes that have a reference to the `Next` node in the collection type as well as a `Value`. The methods and properties of the `Stack` are `top`, `push()`, `pop()`, `peek()`, and `isEmpty()`. The methods and properties of the `Queue` are `front`, `enqueue()`, `dequeue()`, `peek()`, and `isEmpty()`. This Stack and Queue are both generic, meaning that they can hold any data type that is specified upon instantiation.


---

## Methods

### Stack
| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| push | Adds a new value to the Stack | O(1) | O(1) | myStack.push(99) |
| pop | Returns and removes the Stack's top value | O(1) | O(1) | myStack.pop() |
| peek | Returns the Stack's top value | O(1) | O(1) | myStack.peek() |
| isEmpty | Indicates whether the Stack is empty or not | O(1) | O(1) | myStack.isEmpty() |

### Queue
| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| enqueue | Adds a new value to the Queue | O(1) | O(1) | myStack.enqueue(99) |
| dequeue | Returns and removes the Queue's front value | O(1) | O(1) | myStack.dequeue() |
| peek | Returns the Queue's front value | O(1) | O(1) | myStack.peek() |
| isEmpty | Indicates whether the Queue is empty or not | O(1) | O(1) | myStack.isEmpty() |

---

## Stack Methods

### push
Adds a new value to the top of the stack.

### pop
Returns the value on the top of the stack after it is removed from the stack

### peek
Returns the value at the top of the stack.

### isEmpty
Returns a boolean depending on whether the stack has items in it or not.

## Queue Methods

### enqueue
Adds a value to the rear of the queue.

### dequeue
Returns the value at the front of the queue after it is removed from the queue.

### peek
Returns that value at the front of the queue.

### isEmpty
Returns a boolean depending on whether or not the queue has items in it or not.

---

## Change Log
1.0: *Initial Release* - 27 Sept 2020
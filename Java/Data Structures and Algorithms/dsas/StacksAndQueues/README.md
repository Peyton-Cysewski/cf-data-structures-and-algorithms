# Stacks and Queues

*Author: Peyton Cysewski*

---

## Description

A Java implementation of a `Stack` and `Queue`. Stacks and Queues both contain individual nodes that have a reference to the `Next` node in the collection type as well as a `Value`. The methods and properties of the `Stack` are `top`, `push()`, `pop()`, `peek()`, and `isEmpty()`. The methods and properties of the `Queue` are `front`, `enqueue()`, `dequeue()`, `peek()`, and `isEmpty()`. This Stack and Queue are both generic, meaning that they can hold any data type that is specified upon instantiation.


---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| insert | Adds a new `Node` to the `Linked List` at the front | O(1) | O(1) | myList.Insert(99) |
| includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| append | Adds a new `Node` to the `Linked List` to the end | O(1) | O(1) | myList.append(100) |
| insertBefore | Adds a new `Node` to the `Linked List` before a targeted value | O(n) | O(1) | myList.insertBefore(99) |
| insertAfter | Adds a new `Node` to the `Linked List` after a targeted value | O(n) | O(1) | myList.insertAfter100() |
| kthFromEnd | Returns a `Node` from the `Linked List` that is k nodes from the end | O(n) | O(1) | myList.kthFromEnd(3) |
| toString | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |
| zipLists | Interlaces two `Linked List` objects together | O(n) | O(1) | LinkedList.zipLists(list1, list2) |


---

## Stack Methods

## Queue Methodsit 

---

## Change Log
1.0: *Initial Release* - 27 Sept 2020
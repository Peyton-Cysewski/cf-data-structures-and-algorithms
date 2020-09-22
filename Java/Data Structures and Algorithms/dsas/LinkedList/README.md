# Linked List

*Author: Peyton Cysewski*

---

## Description
A Java implementation of a `Singly Linked List`. Singly Linked Lists contain individual nodes that have a reference to the `Next` node in the list as well as a `Value`. The methods of this `Linked List` are `insert`, `includes`, `append`, `insertBefore`, `insertAfter` and `toString`. This Linked List is also a generic linked list, meaning that it can hold any data type that is specified upon instantiation.

---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| insert | Adds a new `Node` to the `Linked List` at the front | O(1) | O(1) | myList.Insert(99) |
| includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| append | Adds a new `Node` to the `Linked List` to the end | O(1) | O(1) | myList.append(100) |
| insertBefore | Adds a new `Node` to the `Linked List` before a targeted value | O(n) | O(1) | myList.insertBefore(99) |
| insertAfter | Adds a new `Node` to the `Linked List` after a targeted value | O(n) | O(1) | myList.insertAfter100() |
| toString | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |


---

## Method Descriptions

### Insert
The insert method takes in an appropriate value and places it at the front of the linked list. This means that if there are any current values already in the list, then they will effectively be pushed back and index.

### Includes
The includes method checks to see if the targeted value exists in the list. It looks through each node of the list and returns true if it finds a match. If not, then it returns false.

### Append
The append method takes a value and adds it to the end of the list. If the list is null, then it will be the only item in the list.

### InsertBefore
The insertBefore method takes in a target value and a new value to add to the list. If the target value is found in the list, then the new value will be added directly in front of it.

### InsertAfter
The insertBefore method takes in a target value and a new value to add to the list. If the target value is found in the list, then the new value will be added directly after it.

### toString
The toString method iterates through the linked list and returns a stringified list of all the values including null. The output format looks like this: `"{1} -> {2} -> {3} -> null"`.
---

## Change Log
1.1: *Added More Insertion Methods* - 21 Sept 2020
1.0: *Initial Release* - 20 Sept 2020
# Linked List

*Author: Peyton Cysewski*

---

## Description
A Java implementation of a `Singly Linked List`. Singly Linked Lists contain individual nodes that have a reference to the `Next` node in the list as well as a `Value`. The methods of this `Linked List` are `Insert`, `Includes` and `toString`. This Linked List is also a generic linked list, meaning that it can hold any data type that is specified upon instantiation.

---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Linked List` at the front | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| toString | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |


---

## Visuals
***[Add screenshots of your methods in action]***

### Insert Method
***[In your own words explain what this method is doing]***
*The Insert Method takes in an int as a parameter. A new Node is then created using the* 
*int param as its Value. The new Node is then placed in the Linked List at the Head and*
*the previous Head is assigned as the new Nodes Next.*
![Image 1](https://via.placeholder.com/750x500)
### Includes Method
***[In your own words explain what this method is doing]***
*The Includes Method takes in an int as a parameter then iterates through the Nodes of the*
*Linked List checking all the Values. If the value is found True is returned, if not then*
*False is returned.*
![Image 1](https://via.placeholder.com/750x500)
### toString Method
***[In your own words explain what this method is doing]***
*The Print Method displays a well formatted depiction of the current state of the*
*Linked List by iterating over all Nodes.*
![Image 1](https://via.placeholder.com/750x500)

---

## Change Log
1.0: *Initial Release* - 18 Sept 2020  
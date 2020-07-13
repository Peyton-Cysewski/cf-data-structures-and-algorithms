# Code Challenge 05

## LinkedList
*Author: Peyton Cysewski*

---

### Problem Domain

Implement a singly-linked linked list and have its implementation stored in a library for future use.

---


### Approach & Efficiency

This challenged was done as a class so the approach was simply to get it done. Our instructor primarily guided us along as we filled in the blanks. The goal was simply to make it work. SIngly linked lists have a few characteristics such as having a value and then a reference to the next node in the list, so that is what we implemented.


---


### API

- ```Insert()``` - Adds a new node to the front of the list (replacing and becoming the new ```Head```).
- ```Includes()``` - Looks through the list for a value and returns a boolean.
- ```ToString()``` - Overrides the native method and returns a list of the values, in order, with a '->' separating each value.


---


### Inputs and Expected Outputs

| Input Code | Console Output |
| :----------- | :----------- |
| ```list.Insert(4);``` | N/A |
| ```list.Insert(3);``` | N/A |
| ```list.Insert(2);``` | N/A |
| ```list.Insert(1);``` | N/A |
| ```list.ToString();``` | 1 -> 2 -> 3 -> 4 -> NULL |


---


### Big O for Looking Through a Linked List

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |


---


### Implementation Visual
##### Code to add to the linked list:
![Input Code](./assets/LinkedListCode.png)

##### Console Output Demonstrated:
![Console Output](./assets/LinkedListOutput.png)


---

### Change Log
1.1: *Initial Release* - 12 July 2020  

---
# Zipped Linked List

## ArrayShift
*Author: Peyton Cysewski*

---

### Problem Domain

Given two linked lists, zip the lists together so that the nodes alternate pointing between one another to create a single, large list. Return the head of the single zipped list.

---

### Inputs and Expected Outputs

| Arg ```list1``` | Arg ```list2``` | Expected Output |
| :----------- | :----------- | :----------- |
| ```1 -> 3 -> 5 -> NULL``` | ```2 -> 4 -> 6 -> NULL``` | ```1 -> 2 -> 3 -> 4 -> 5 -> 6 -> NULL``` |
| ```1 -> 3 -> 5 -> 7 -> NULL``` | ```2 -> 4 -> 6 -> NULL``` | ```1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> NULL``` |
| ```1 -> 3 -> 5 -> NULL``` | ```2 -> 4 -> 6 -> 8 -> NULL``` | ```1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 8 -> NULL``` |
| ```1 -> 3 -> 5 -> 7 -> 9 -> 11 -> NULL``` | ```2 -> 4 -> 6 -> NULL``` | ```1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 9 -> 11 -> NULL``` |
| ```1 -> 3 -> 5 -> NULL``` | ```2 -> 4 -> 6 -> 8 -> 10 -> 12 -> NULL``` | ```1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 8 -> 10 -> 12 -> NULL``` |
| ```NULL``` | ```2 -> 4 -> 6 -> NULL``` | ```2 -> 4 -> 6 -> NULL``` |
| ```1 -> 3 -> 5 -> NULL``` | ```NULL``` | ```1 -> 3 -> 5 -> NULL``` |

---

### Approach
Knowing that the lists had to alternate referencing one and then the other, it became clear that there was an underlying pattern. The zig-zag nature was actually cyclical which meant that the reference patter could go until a certain condition was met. In this case, the condition would be that the cycle had iterated to the end of one of the lists or both of the lists. If both lists are the same in length, then this problem solves itself. But if the two arrays are of lengths that differ by more than one, then the conditions will kick into action and quit the back and forth cycle, leaving the remaining nodes untouched and exactly as they should be.

---


### Big O

| Time | Space |
| :----------- | :----------- |
| O(1) | O(n) |


---


### Whiteboard Visual
![Zipped Linked List Whiteboard](./assets/ZippedListWhiteboard.png)


---

### Change Log
1.1: *Initial Release* - 16 July 2020  

---
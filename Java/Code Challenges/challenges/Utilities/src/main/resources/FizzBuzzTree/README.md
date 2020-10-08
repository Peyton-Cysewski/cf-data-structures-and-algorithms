# K-ary FizzBuzz Tree

*Author: Peyton Cysewski*

---

## Problem Domain

First create a k-ary tree that can hold integers. Next, create a method that takes a k-ary integer tree and makes a new tree where each integer is instead replaces by "Fizz" if it is divisible by 3, "Buzz" if it is divisible by 5, and "FizzBuzz" if it is divisible by 15. These are of course strings, meaning that the new tree would also have to be a k-ary string tree.

---

## Classes and Methods

### [KaryNode<T>](../../java/utilities/KaryNode.java)
challenges/Utilities/src/main/java/utilities/KaryTree.java
This class is required for a k-ary tree. Because each node can have any arbitrary number of children nodes, it needs a data structure that can do this, so I added an ArrayList to hold hold the children. Children can be added to the array list, but not removed from it since that functionality is not currently needed. This class is generic.

### KaryTree<T>
The k-ary tree needs to hold all of it's nodes, so it uses the KaryNode class for it's nodes. It is generic, and the nodes it holds must also be of the same generic type.

#### preOrder
This method returns a string representing all of the nodes in the k-ary tree as traversed using a pre-order type traversal. The format goes: `"root -> node1 -> node2 -> node3"`. This is an O(n) time and space operation.

#### fizzBuzzTree
This method returns a new k-ary string tree. Each node in this tree is in the same relative position as the k-ary integer tree from which it was formed. In this tree, the titular and well-known FizzBuzz function was applied to it. This tree is of the same generic type as the tree from which it was made, meaning that it too has access to the preOrder method. This was useful in testing and can also properly demonstrate how all of the nodes are in the same place. The output strings would be identical except for the integer representations that were "FizzBuzz'ed". This is an O(n) time and space operation.

---

### Change Log
1.0: *Initial Submission* - 7 October 2020  

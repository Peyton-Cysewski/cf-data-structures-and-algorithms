# Trees

*Author: Peyton Cyserwski*

---

## Description
Trees are data structures that have a sort of branching structure (hence the name) that relates one `Root` node to children nodes, usually a `LeftChild` and a `RightChild`. Traditionally, there are can be a maximum of exactly two children nodes per root node. Each of these children are roots to their own children. Because of this structure, there can be relationships between the parent and root nodes that can be exploited. For example, a Binary Search Tree puts values smaller than the root on the left and ones larger on the right. This means that there is a direct and organized route to every endpoint on a tree (know as leaves).

---

## Methods

| Method | Summary | Big O Time | Big O Space |
| :----------- | :----------- | :-------------: | :-------------: |
| PreOrder | Traverses through a tree odered by: Root, Left, Right | O(n) | O(1) |
| InOrder | Traverses through a tree odered by: Left, Root, Right | O(n) | O(1) |
| PostOrder | Traverses through a tree odered by: Left, Right, Root | O(n) | O(1) |


---

### PreOrder Method
![PreOrder Diagram](./assets/preorder.png)
*The PreOrder method of traversing through a tree looks at the root first before proceeding on to the root's left child and its right child. The diagram above shows the order in which the nodes will be ordered after traversing the tree with this method.*
### InOrder Method
![InOrder Diagram](./assets/inorder.png)
*The InOrder method of traversing through a tree looks at the root's left child first before proceeding on to the root itself and then finally its right child. The diagram above shows the order in which the nodes will be ordered after traversing the tree with this method.*
### PostOrder Method
![PostOrder Diagram](./assets/postorder.png)
*The PostOrder method of traversing through a tree looks at the root's left child first before proceeding on to the root's left child and then finally the root itself. The diagram above shows the order in which the nodes will be ordered after traversing the tree with this method.*

---

## Change Log
1.1: *Initial Release* - 26 July 2020

---
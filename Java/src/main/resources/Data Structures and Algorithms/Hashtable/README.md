# Hashtable

*Author: Peyton Cysewski*

---

## Challenge
Create an implementation of a hashtable using either my own linked lists or the built-in ones.

---

## Approach & Efficiency
I ended up using the built-in linked lists because they have nodes that allowed for generic types. Inside of those nodes I housed my key/value pairs in a data type I made up called 'Pair' that contains properties called 'key' and 'value'. The overall design is elementary as it is just a large array that houses a new linked list at each index. If there are any collisions from the hash, then it will attach a node containing a 'Pair' object to the end of the linked list at that index.

---

## Methods
- `Add`: Takes a key and a value and adds it to the hashtable.
- `Get`: Takes in a target key and returns the associated value.
- `Contains`: Checks whether or not the targeted key exists in the hashtable.
- `Hash`: A private method that converts a key (as a string) to a specific index value of the underlying hashtable array.

---

### Inputs and Expected Outputs

| State | Input | Expected Output |
| :----------- | :----------- | :--------- |
| `hashtable.Add("Key", 10)` | `hashtable.Get("Key")` | `10` |
| `hashtable.Add("Key", 10)` | `hashtable.Contains("Key")` | `True` |
| `hashtable.Add("Key", 10)` | `hashtable.Contains("Different Key")` | `False` |


---

### Big O

| Time | Space |
| :----------- | :----------- |
| O(1) | O(n) |

---

### Change Log
1.0: *Initial Release* - 25 October 2020
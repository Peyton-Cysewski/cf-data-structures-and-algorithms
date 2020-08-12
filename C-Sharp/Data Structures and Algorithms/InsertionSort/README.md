# Insertion Sort Algorithm

*Author: Peyton Cysewski*

---

## Description
Insertion sort is a sorting algorithm that compares a value to its leftward neighbor and moves it left if it is smaller. It repeats this process until the value can no longer move to the left. The algorithm then repeats those steps with the next number in the list until it too cannot move to the left. Once the algorithm has iterated thorugh the entire list, then it will be sorted.

---

## Big O

| Time | Space | Input | Outcome |
| :----------- | :----------- | :-------------: | :-------------: |
| O(n^2) | O(1) | `[ 8, 4, 23, 42, 16, 15 ]` | `[ 4, 8, 15, 16, 23, 42 ]` |

---

## Visuals

### First Iteration
![`Step 1`](./assets/Step%201.png)
</br>

### Second Iteration
![`Step 2`](./assets/Step%202.png)
</br>

### Third Iteration
![`Step 3`](./assets/Step%203.png)
</br>

### Fourth Iteration
![`Step 4`](./assets/Step%204.png)
</br>

### Fifth Iteration
![`Step 5`](./assets/Step%205.png)
</br>

### Final Result
![Result](./assets/Result.png)

---

## Change Log
1.1: *Initial Release* - 10 August 2020
# Insertion Sort

Quick sort is a recursive algorithm that depends on something called the pivot. The way this works is by first choosing this pivot. The pivot ideally would be a number that is the median or close the the mediam number in an array. The pivot is then swapped with the right-most array index item. If not, then it is common to just choose the current right-most item as the starting pivot. Then two references look at numbers starting from both the right and the left sides of the array (excluding the right-most item that was set aside as the pivot). The reference that is on the left side moves to the right one at a time until it finds a number larger than the pivot. At the same time the reference on the right side moves left one at a time until it finds an item smaller than the pivot. Once both values are found, they are swapped. This cycle continues until the two references cross over one another signaling that all the values have been correctly placed on their respective sides. The pivot (on the far right) is then swapped back to its original position. Because the array has been rearranges around the pivot point, the pivot is now in the correct index postion relative to the entire array. This algorithm is then applied recursively until every item has been placed in the correct position and it is sorted.

### Image 1
![Image 1](./assets/)

### Image 2
![Image 2](./assets/)

### Image 3
![Image 3](./assets/)

### Image 4
![Image 4](./assets/)

### Image 5
![Image 5](./assets/)
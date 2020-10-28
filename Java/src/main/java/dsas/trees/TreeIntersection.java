package dsas.trees;

import java.util.ArrayList;
import java.util.HashSet;

public class TreeIntersection {
public static ArrayList<Integer> FindIntersections(Tree tree1, Tree tree2) {
    ArrayList<Integer> intersections = new ArrayList<>();
        if (tree1.root != null && tree2.root != null) {
            HashSet<Integer> hashset = new HashSet<>();
            Object[] treeList1 = tree1.InOrder();
            for (Object num : treeList1) {
                if (!hashset.contains(num)) {
                    hashset.add((Integer) num);
                }
            }
            Object[] treeList2 = tree2.InOrder();
            for (Object num : treeList2) {
                if (hashset.contains(num)) {
                    if (!intersections.contains(num)) {
                        intersections.add((Integer) num);
                    }
                }
            }
        }
        return intersections;
    }
}
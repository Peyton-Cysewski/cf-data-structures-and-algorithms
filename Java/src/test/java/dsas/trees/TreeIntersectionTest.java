package dsas.trees;

import org.junit.Test;

import java.util.ArrayList;

import static org.junit.Assert.*;

public class TreeIntersectionTest {
    private Tree makeATree() {
        Node one = new Node(1);
        Node two = new Node(2);
        Node three = new Node(3);
        Node four = new Node(4);
        Node five = new Node(5);
        Node six = new Node(6);
        Node seven = new Node(7);
        two.leftChild = one;
        two.rightChild = three;
        six.leftChild = five;
        six.rightChild = seven;
        four.leftChild = two;
        four.rightChild = six;
        return new Tree(four);
    }

    @Test public void testIntersectionsAreDetectedProperly() {
        Tree tree1 = makeATree();
        Tree tree2 = new Tree(1);
        ArrayList<Integer> expected = new ArrayList<>();
        expected.add(1);

        assertEquals("The only intersection should be 1.", expected, TreeIntersection.FindIntersections(tree1, tree2));
    }

    @Test public void testWorksWithNoIntersections() {
        Tree tree1 = makeATree();
        Tree tree2 = new Tree(8);
        ArrayList<Integer> expected = new ArrayList<>();

        assertEquals("The result should be an empty ArrayList.", expected, TreeIntersection.FindIntersections(tree1, tree2));
    }

    @Test public void testWorksWithAnEmptyTree() {
        Tree tree1 = makeATree();
        Tree tree2 = new Tree();
        ArrayList<Integer> expected = new ArrayList<>();

        assertEquals("The result should be an empty ArrayList.", expected, TreeIntersection.FindIntersections(tree1, tree2));
    }

    @Test public void testMultipleIntersectionsAreDetectedProperly() throws Exception {
        Tree tree1 = makeATree();
        Tree tree2 = makeATree();
        ArrayList<Integer> expected = new ArrayList<>();
        expected.add(1);
        expected.add(2);
        expected.add(3);
        expected.add(4);
        expected.add(5);
        expected.add(6);
        expected.add(7);

        assertEquals("The intersections should be 1 through 7.", expected, TreeIntersection.FindIntersections(tree1, tree2));
    }
}

package utilities;

import org.junit.Test;
import static org.junit.Assert.*;

public class KaryTreeTest {
    private KaryTree<Integer> makeTree() {
        KaryNode<Integer> n1 = new KaryNode<>(1);
        KaryNode<Integer> n2 = new KaryNode<>(2);
        KaryNode<Integer> n3 = new KaryNode<>(3);
        KaryNode<Integer> n4 = new KaryNode<>(4);
        KaryNode<Integer> n5 = new KaryNode<>(5);
        KaryNode<Integer> n6 = new KaryNode<>(6);
        KaryNode<Integer> n7 = new KaryNode<>(7);
        KaryNode<Integer> n8 = new KaryNode<>(8);
        KaryNode<Integer> n9 = new KaryNode<>(9);
        KaryNode<Integer> n10 = new KaryNode<>(10);
        KaryNode<Integer> n11 = new KaryNode<>(11);
        KaryNode<Integer> n12 = new KaryNode<>(12);
        KaryNode<Integer> n13 = new KaryNode<>(13);
        KaryNode<Integer> n14 = new KaryNode<>(14);
        KaryNode<Integer> n15 = new KaryNode<>(15);
        /*
                               1
                  /        /      \         \
                 2        3        4         14
               / | \    / | \    / | \        |
              5  6  7   8 9 10  11 12 13     15
         */
        n2.addChild(n5);
        n2.addChild(n6);
        n2.addChild(n7);

        n3.addChild(n8);
        n3.addChild(n9);
        n3.addChild(n10);

        n4.addChild(n11);
        n4.addChild(n12);
        n4.addChild(n13);

        n14.addChild(n15);


        n1.addChild(n2);
        n1.addChild(n3);
        n1.addChild(n4);
        n1.addChild(n14);

        KaryTree<Integer> tree = new KaryTree<>(n1);
        return tree;
    }

    @Test public void testKaryTreeTraversal() {
        KaryTree<Integer> tree = makeTree();
        String expected = "root -> 1 -> 2 -> 5 -> 6 -> 7 -> 3 -> 8 -> 9 -> 10 -> 4 -> 11 -> 12 -> 13 -> 14 -> 15";
        String actual = tree.preOrder();
        assertEquals("String shows a proper traversal of a kary tree", expected, actual);
    }

    @Test public void testKaryTreeFizzBuzz() throws Exception {
        KaryTree<Integer> original = makeTree();
        KaryTree<String> fizzBuzzed = original.fizzBuzzTree();
        String expected = "root -> 1 -> 2 -> Buzz -> Fizz -> 7 -> Fizz -> 8 -> Fizz -> Buzz -> 4 -> 11 -> Fizz -> 13 -> 14 -> FizzBuzz";
        String actual = fizzBuzzed.preOrder();
        assertEquals("Properly converted from integers to strings with FizzBuzz changes", expected, actual);
    }
}

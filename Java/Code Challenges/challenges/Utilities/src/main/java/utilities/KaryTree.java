package utilities;

import java.util.ArrayList;

public class KaryTree<T> {
    KaryNode<T> root = null;

    public KaryTree(KaryNode<T> node) { this.root = node; }

    public KaryTree<String> fizzBuzzTree() throws Exception {
        if (root.getValue().getClass() != Integer.class) throw new Exception("FizzBuzz can only be performed on a Integer tree");
        KaryTree<String> resultTree = new KaryTree<>(new KaryNode<>(fizzBuzz(this.root)));
        Stack<KaryNode> stack = new Stack<>();
        fizzBuzzTree(this.root, resultTree.root);
        return resultTree;
    }

    private void fizzBuzzTree(KaryNode orig, KaryNode copy) {
        if (orig.getChildren().size() == 0) return;
        for (int i = 0; i  < orig.getChildren().size(); i++) {
            copy.addChild(new KaryNode(fizzBuzz((KaryNode<T>) orig.getChildren().get(i))));
            fizzBuzzTree((KaryNode) orig.getChildren().get(i), (KaryNode) copy.getChildren().get(i));
        }
    }

    private String fizzBuzz(KaryNode<T> node) {
        Integer num = (Integer) node.getValue();
        if (num % 3 == 0) return "Fizz";
        else if (num % 5 == 0) return "Buzz";
        else if (num % 15 == 0) return "FizzBuzz";
        return num.toString();
    }

    public String preOrder() {
        return "root -> " + preOrder(this.root);
    }

    private String preOrder(KaryNode node) {
        String res = node.getValue().toString();
        for (KaryNode next : (ArrayList<KaryNode>) node.getChildren()) {
            res += " -> " + preOrder(next);
        }
        return res;
    }
}
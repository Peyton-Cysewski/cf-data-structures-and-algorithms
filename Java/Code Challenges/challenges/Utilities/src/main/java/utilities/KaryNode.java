package utilities;

import org.checkerframework.checker.units.qual.K;

import java.util.ArrayList;

public class KaryNode<T> {
    private T value;
    private ArrayList<KaryNode<T>> children = new ArrayList<>();

    public KaryNode(T value) {
        this.value = value;
    }

    public T getValue() { return value; }
    public void setValue(T value) { this.value = value; }

    public ArrayList<KaryNode<T>> getChildren() { return children; }
    public void addChild(KaryNode<T> node) { children.add(node); }
}

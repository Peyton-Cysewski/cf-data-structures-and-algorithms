package dsas.graph;

import java.util.ArrayList;

public class GraphNode {
    public int value;
    public ArrayList<GraphEdge> edges = new ArrayList<>();

    public GraphNode(int value) {
        this.value = value;
    }
}

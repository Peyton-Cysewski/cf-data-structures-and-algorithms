package dsas.graph;

import java.util.ArrayList;

public class GraphNode {
    public int value;
    public ArrayList<GraphEdge> edges;

    public GraphNode(int value) {
        this.value = value;
    }
}

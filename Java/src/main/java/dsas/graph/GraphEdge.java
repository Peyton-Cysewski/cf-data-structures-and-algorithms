package dsas.graph;

public class GraphEdge {
    public int cost;
    public GraphNode node;

    public GraphEdge(int cost, GraphNode node) {
        this.cost = cost;
        this.node = node;
    }
}

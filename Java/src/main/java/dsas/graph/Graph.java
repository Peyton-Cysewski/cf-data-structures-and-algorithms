package dsas.graph;

import java.util.ArrayList;
import java.util.HashSet;

public class Graph {
    private HashSet<GraphNode> nodes = new HashSet<>();

    public Graph() {}

    public GraphNode addNode(int value) {
        GraphNode node = new GraphNode(value);
        nodes.add(node);
        return node;
    }

    public void addEdge(GraphNode host, GraphNode neighbor, int weight) throws Exception {
        if (!nodes.contains(host) || !nodes.contains(neighbor))
            throw new Exception("One or both of the nodes does not exist in the graph.");
        GraphEdge edge = new GraphEdge(weight, neighbor);
        host.edges.add(edge);
    }

    public GraphNode[] getNodes() {
        return (GraphNode[]) nodes.toArray();
    }

    public GraphEdge[] getNeighbors(GraphNode node) {
        return (GraphEdge[]) node.edges.toArray();
    }

    public int size() {
        return nodes.size();
    }
}

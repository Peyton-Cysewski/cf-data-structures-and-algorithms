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
        if (host.edges == null)
            host.edges = new ArrayList<>();
        host.edges.add(edge);
    }

    public GraphNode[] getNodes() {
        GraphNode[] arr = new GraphNode[nodes.size()];
        int i = 0;
        for (GraphNode node : nodes) {
            arr[i++] = node;
        }
        return arr;
    }

    public GraphEdge[] getNeighbors(GraphNode node) {
        GraphEdge[] arr = new GraphEdge[node.edges.size()];
        int i = 0;
        for (GraphEdge edge : node.edges) {
            arr[i++] = edge;
        }
        return arr;
    }

    public int size() {
        return nodes.size();
    }
}

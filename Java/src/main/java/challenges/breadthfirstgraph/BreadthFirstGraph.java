package challenges.breadthfirstgraph;

import dsas.graph.*;

import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Queue;
import java.util.concurrent.ConcurrentLinkedQueue;

public class BreadthFirstGraph {
    public static GraphNode[] bfs(Graph graph, GraphNode root) {
        if (graph == null || graph.size() == 0) return null;
        GraphNode[] result = new GraphNode[graph.size()];
        HashSet<GraphNode> visited = new HashSet<>();
        Queue<GraphEdge> q = new ConcurrentLinkedQueue<>();
        q.add(new GraphEdge(0, root));
        int i = 0;
        while (!q.isEmpty()) {
            GraphEdge edge = q.remove();
            if (!visited.contains(edge.node)) {
                visited.add(edge.node);
                result[i++] = edge.node;
                if (edge.node.edges != null) {
                    for (GraphEdge newEdge : edge.node.edges) {
                        q.add(newEdge);
                    }
                }
            }
        }
        return result;
    }
}

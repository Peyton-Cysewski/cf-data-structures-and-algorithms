package challenges.depthfirstgraph;

import dsas.graph.*;

import java.util.HashSet;
import java.util.Queue;
import java.util.Stack;
import java.util.concurrent.ConcurrentLinkedQueue;

public class DepthFirstGraph {
    public static GraphNode[] dfs(Graph graph, GraphNode root) {
        if (graph == null || graph.size() == 0) return null;
        GraphNode[] result = new GraphNode[graph.size()];
        HashSet<GraphNode> visited = new HashSet<>();
        Stack<GraphEdge> s = new Stack<>();
        s.push(new GraphEdge(0, root));
        int i = 0;
        while (!s.isEmpty()) {
            GraphEdge edge = s.pop();
            if (!visited.contains(edge.node)) {
                visited.add(edge.node);
                result[i++] = edge.node;
                if (edge.node.edges != null) {
                    for (GraphEdge newEdge : edge.node.edges) {
                        s.push(newEdge);
                    }
                }
            }
        }
        return result;
    }
}

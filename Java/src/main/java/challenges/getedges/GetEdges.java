package challenges.getedges;

import dsas.graph.*;
import challenges.breadthfirstgraph.BreadthFirstGraph;

import java.util.ArrayList;

public class GetEdges {
    public static Result calculate(Graph graph, String[] path) {
        Result result = new Result(false, 0);
        if (graph == null) return result;
        int cost = 0;
        GraphNode[] nodes = graph.getNodes();
        if (nodes == null || path == null) return result;
        GraphNode current = null;
        if (nodes.length > 0 && path.length > 0) {
            for (int i = 0; i < nodes.length; i++) {
                if (((CityNode) nodes[i]).cityName.equals(path[0])) {
                    current = nodes[i];
                }
            }
            if (current == null) return result;
        }
        else return result;
        for (int i = 1; i < path.length; i++) {
            ArrayList<GraphEdge> connections = current.edges;
            for (GraphEdge edge : connections) {
                if (((CityNode) edge.node).cityName.equals(path[i])) {
                    cost += edge.cost;
                    current = (CityNode) edge.node;
                }
                else return result;
            }
        }
        result.cost = cost;
        result.isPossible = true;
        return result;
    }
}

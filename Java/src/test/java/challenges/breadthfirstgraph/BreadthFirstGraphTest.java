package challenges.breadthfirstgraph;

import dsas.graph.*;

import org.junit.Test;
import static org.junit.Assert.*;

public class BreadthFirstGraphTest {
    @Test public void testBFS() throws Exception {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        GraphNode node3 = graph.addNode(3);
        GraphNode node4 = graph.addNode(4);
        GraphNode node5 = graph.addNode(5);

        graph.addEdge(node1, node2, 1);
        graph.addEdge(node2, node3, 1);
        graph.addEdge(node3, node4, 1);
        graph.addEdge(node3, node5, 1);
        graph.addEdge(node5, node2, 1);

        GraphNode[] bfs = BreadthFirstGraph.bfs(graph, node1);

        GraphNode[] expected = {node1, node2, node3, node4, node5};
        assertArrayEquals(expected, bfs);
    }

    @Test public void testBFSOrder() throws Exception {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        GraphNode node3 = graph.addNode(3);
        GraphNode node4 = graph.addNode(4);
        GraphNode node5 = graph.addNode(5);
        GraphNode node6 = graph.addNode(6);
        GraphNode node7 = graph.addNode(7);

        graph.addEdge(node1, node2, 1);
        graph.addEdge(node1, node4, 1);
        graph.addEdge(node4, node7, 1);
        graph.addEdge(node7, node5, 1);
        graph.addEdge(node5, node6, 1);
        graph.addEdge(node5, node2, 1);
        graph.addEdge(node5, node3, 1);
        graph.addEdge(node3, node7, 1);


        GraphNode[] bfs = BreadthFirstGraph.bfs(graph, node1);

        GraphNode[] expected = {node1, node2, node4, node7, node5, node6, node3};
        assertArrayEquals(expected, bfs);
    }

    @Test public void testEmptyBFS() throws Exception {
        Graph graph = new Graph();
        GraphNode node1 = new GraphNode(1);
        
        GraphNode[] bfs = BreadthFirstGraph.bfs(graph, node1);

        assertNull(bfs);
    }
}

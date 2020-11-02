package dsas.graph;

import org.junit.Test;

import java.util.ArrayList;

import static org.junit.Assert.*;

public class GraphTest {
    @Test public void testAddNode() {
        Graph graph = new Graph();
        graph.addNode(5);
        assertEquals(1, graph.size());
        assertEquals(5, graph.getNodes()[0].value);
    }

    @Test public void testAddEdge() throws Exception {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        graph.addEdge(node1, node2, 5);
        assertEquals(2, graph.size());
        assertEquals(5, node1.edges.get(0).cost);
    }

    @Test public void testGetNodes() {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        assertEquals(2, graph.size());
        GraphNode[] nodes = graph.getNodes();
        assertEquals(node1, nodes[0]);
        assertEquals(node2, nodes[1]);
    }

    @Test public void testGetNeighbors() throws Exception {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        GraphNode node3 = graph.addNode(3);
        GraphNode node4 = graph.addNode(4);
        graph.addEdge(node1, node2, 5);
        graph.addEdge(node1, node3, 5);
        graph.addEdge(node1, node4, 5);
        GraphEdge[] neighbors = graph.getNeighbors(node1);
        assertEquals(4, graph.size());
        assertEquals(3, neighbors.length);
        assertEquals(node2, neighbors[0].node);
        assertEquals(node3, neighbors[1].node);
        assertEquals(node4, neighbors[2].node);
    }

    @Test public void testGetWeightsOfEdges() throws Exception {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        GraphNode node3 = graph.addNode(3);
        GraphNode node4 = graph.addNode(4);
        graph.addEdge(node1, node2, 5);
        graph.addEdge(node1, node3, 15);
        graph.addEdge(node1, node4, 25);
        GraphEdge[] neighbors = graph.getNeighbors(node1);

        assertEquals(5, neighbors[0].cost);
        assertEquals(15, neighbors[1].cost);
        assertEquals(25, neighbors[2].cost);
    }

    @Test public void testGetSize() {
        Graph graph = new Graph();
        GraphNode node1 = graph.addNode(1);
        GraphNode node2 = graph.addNode(2);
        GraphNode node3 = graph.addNode(3);
        GraphNode node4 = graph.addNode(4);
        GraphNode node5 = graph.addNode(5);

        assertEquals(5, graph.size());
    }

    @Test public void testGetOneNode() {
        Graph graph = new Graph();
        graph.addNode(5);
        assertEquals(1, graph.size());
        assertEquals(5, graph.getNodes()[0].value);
    }
}

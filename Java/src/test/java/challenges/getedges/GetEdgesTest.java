package challenges.getedges;

import dsas.graph.*;

import org.junit.Test;

import java.util.HashSet;

import static org.junit.Assert.*;

public class GetEdgesTest {
    @Test public void testGetEdges() {
        Graph graph = new Graph();
        HashSet<GraphNode> nodes = new HashSet<>();
        CityNode node1 = new CityNode(1, "City1");
        CityNode node2 = new CityNode(2, "City2");
        CityNode node3 = new CityNode(3, "City3");
        GraphEdge edge1 = new GraphEdge(10, node2);
        GraphEdge edge2 = new GraphEdge(20, node3);
        node1.edges.add(edge1);
        node2.edges.add(edge2);
        nodes.add(node1);
        nodes.add(node2);
        nodes.add(node3);
        graph.nodes = nodes;

        String[] path = {"City1", "City2", "City3"};

        Result actual = GetEdges.calculate(graph, path);
        String expected = "True, $30";

        assertEquals(expected, actual.toString());
    }

    @Test public void testNullGraph() {
        Graph graph = null;
        String[] path = {"City1", "City2", "City3"};

        Result actual = GetEdges.calculate(graph, path);
        String expected = "False, $0";

        assertEquals(expected, actual.toString());
    }

    @Test public void testNullPath() {
        Graph graph = new Graph();
        HashSet<GraphNode> nodes = new HashSet<>();
        CityNode node1 = new CityNode(1, "City1");
        CityNode node2 = new CityNode(2, "City2");
        CityNode node3 = new CityNode(3, "City3");
        GraphEdge edge1 = new GraphEdge(10, node2);
        GraphEdge edge2 = new GraphEdge(20, node3);
        node1.edges.add(edge1);
        node2.edges.add(edge2);
        nodes.add(node1);
        nodes.add(node2);
        nodes.add(node3);
        graph.nodes = nodes;

        String[] path = null;

        Result actual = GetEdges.calculate(graph, path);
        String expected = "False, $0";

        assertEquals(expected, actual.toString());
    }

    @Test public void testNotPossiblePath() {
        Graph graph = new Graph();
        HashSet<GraphNode> nodes = new HashSet<>();
        CityNode node1 = new CityNode(1, "City1");
        CityNode node2 = new CityNode(2, "City2");
        CityNode node3 = new CityNode(3, "City3");
        GraphEdge edge1 = new GraphEdge(10, node2);
        GraphEdge edge2 = new GraphEdge(20, node3);
        node1.edges.add(edge1);
        node2.edges.add(edge2);
        nodes.add(node1);
        nodes.add(node2);
        nodes.add(node3);
        graph.nodes = nodes;

        String[] path = {"City1", "City4", "City3"};

        Result actual = GetEdges.calculate(graph, path);
        String expected = "False, $0";

        assertEquals(expected, actual.toString());
    }
}

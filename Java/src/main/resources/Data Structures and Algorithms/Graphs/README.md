# Graphs
Graphs are a type of data structure that represents data points and connections between them. There are many types of graphs, but this implementation allows for weighted connections. These data points and their connections are called nodes and edges.

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include the following methods:
- AddNode()
- AddEdge()
- GetNodes()
- GetNeighbors()
- Sice()

## Approach
Some graphs can be easily visualized, but it can be a bit trickier to do so in code. There are two main ways of representing this data. The first is called a adjacency matrix, where the horizontal and vertical axis represent the connections between two nodes and the intersection in the matrix represents the weight of the connection (or edges as it is properly called). The other prominent way of representing this data is with an adjacency list. This is simply a list a of all the nodes in the graph but each node has list attached to it that represents all the edges (and therefore nodes) it connects to. This is the data representation that I am using in my implementation.

## Efficiency
This is a bit of a black box. Each data point has to be represented as a node at a minimum. So at the very least there is a O(n) efficiency. Different subsets of graphs will have differing efficiency fingerprints, so to speak, but the most expensive example would be a completed graph in which every node connect to every other node. If these connections also happen to be weighted then the amount of data that needs to be stored in roughly O(n^2) or O(n^3).

## Methods
AddNode()
- Adds a new node to the graph
- Takes in the value of that node
- Returns the added node
AddEdge()
- Adds a new edge between two nodes in the graph
- Include the ability to have a “weight”
- Takes in the two nodes to be connected by the edge
- Both nodes should already be in the Graph
GetNodes()
- Returns all of the nodes in the graph as a collection (set, list, or similar)
GetNeighbors()
- Returns a collection of edges connected to the given node
- Takes in a given node
- Include the weight of the connection in the returned collection
Size()
- Returns the total number of nodes in the graph

## Change Log
- 1.0 *Initial Release* - 2 November 2020
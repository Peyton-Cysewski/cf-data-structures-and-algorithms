package challenges.getedges;

import dsas.graph.GraphNode;

public class CityNode extends GraphNode {
    public String cityName;

    public CityNode(int value, String cityName) {
        super(value);
        this.cityName = cityName;
    }
}

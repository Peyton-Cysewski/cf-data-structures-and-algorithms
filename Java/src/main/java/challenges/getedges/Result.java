package challenges.getedges;

public class Result {
    public boolean isPossible;
    public int cost;

    public Result(boolean isPossible, int cost) {
        this.isPossible = isPossible;
        this.cost = cost;
    }

    public String toString() {
        return (isPossible ? "True" : "False") + ", $" + cost;
    }
}

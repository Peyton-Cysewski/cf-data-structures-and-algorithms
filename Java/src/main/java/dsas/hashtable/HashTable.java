package dsas.hashtable;

import java.util.ArrayList;

public class HashTable<V> {
    private ArrayList<Pair<V>>[] bucket;

    /**
     * NOTE: This implementation of a hashtable can uses Strings as keys. Any objects work for the value.
     * @param size The size of the internal data structure for holding key, values pairs.
     */
    public HashTable(int size) {
        bucket = new ArrayList[size];
    }

    public void add(String key, V value) {
        int index = hash(key);
        Pair<V> pair = new Pair<>(key, value);
        if (bucket[index] == null) {
            bucket[index] = new ArrayList<>();
        }
        bucket[index].add(pair);
    }

    public V get(String key) {
        int index = hash(key);
        if (bucket[index] != null) {
            for (Pair pair : bucket[index]) {
                if (pair.getKey().equals(key)) {
                    return (V)pair.getValue();
                }
            }
        }
        return null;
    }

    public boolean contains(String key) {
        int index = hash(key);
        if (bucket[index] != null) {
            for (Pair pair : bucket[index]) {
                if (pair.getKey().equals(key)) {
                    return true;
                }
            }
        }
        return false;
    }

    private int hash(String key) {
        int hash = 0;
        for (int i = 0; i < key.length(); i++) {
            hash += (key.charAt(i) * (i + 1));
        }
        hash = (hash * 4999) % bucket.length;
        return hash;
    }
}

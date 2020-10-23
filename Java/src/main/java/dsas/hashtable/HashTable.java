package dsas.hashtable;

import java.util.ArrayList;

public class HashTable<K, V> {
    private ArrayList<Integer> Bucket;

    /**
     * NOTE: This implementation of a hashtable can use only strings or ints as keys. Any objects work for the value.
     * @param size The size of the internal data structure for holding key, values pairs.
     */
    public HashTable(int size) {
        Bucket = new ArrayList<>(size);
    }

    public void add(K key, V value) {

    }

    // Hash algorithm Driver method
    private int hash(K key) throws Exception {
        int hash = 0;
        String _class = key.getClass().getSimpleName();
        switch (_class) {
            case "String":
                hash = hashString((String) key);
                break;
            case "Integer":
//                hash = hashInteger((Integer) key);
                break;
            default:
                throw new Exception("Key type not supported");
        }
        return hash;
    }

    // string hashing method
    private int hashString(String key) {
        int hash;
        return 0;
    }
}

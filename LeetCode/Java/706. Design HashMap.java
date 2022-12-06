import java.util.Dictionary;
import java.util.Hashtable;

class MyHashMap {

    Dictionary map;

    public MyHashMap() {
        map = new Hashtable();
    }
    
    public void put(int key, int value) {
        map.put(key, value);
    }
    
    public int get(int key) {
        if(map.get(key) == null) {
            return -1;
        }

        return (int) map.get(key);
    }
    
    public void remove(int key) {
        map.remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.put(key,value);
 * int param_2 = obj.get(key);
 * obj.remove(key);
 */
class MyHashSet {

    List<Integer> hashList;

    public MyHashSet() {
        hashList = new ArrayList<Integer>();
    }
    
    public void add(int key) {
        if(!contains(key)) {
            hashList.add(key);
        }
    }
    
    public void remove(int key) {
        hashList.remove(Integer.valueOf(key));
    }
    
    public boolean contains(int key) {
        boolean containsKey = false;

        for(int num : hashList) {
            if(num == key) {
                containsKey = true;
                break;
            }
        }

        return containsKey;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.add(key);
 * obj.remove(key);
 * boolean param_3 = obj.contains(key);
 */
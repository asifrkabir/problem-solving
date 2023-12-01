class RandomizedSet {

    private Set<Integer> randomizedSet;

    public RandomizedSet() {
        randomizedSet = new LinkedHashSet<Integer>();
    }
    
    public boolean insert(int val) {
        int oldSizeOfSet = randomizedSet.size();
        randomizedSet.add(val);
        int newSizeOfSet = randomizedSet.size();

        return oldSizeOfSet != newSizeOfSet;
    }
    
    public boolean remove(int val) {
        int oldSizeOfSet = randomizedSet.size();
        randomizedSet.remove(val);
        int newSizeOfSet = randomizedSet.size();

        return oldSizeOfSet != newSizeOfSet;
    }
    
    public int getRandom() {
        int min = 0;
        int max = randomizedSet.size() - 1;
        int randomIndex = (int)(Math.random() * (max - min + 1) - min);

        Iterator<Integer> it = randomizedSet.iterator();
        int index = 0;
        while (it.hasNext()) {
            int x = it.next();

            if (index == randomIndex) {
                return x;
            }

            index++;
        }

        return 0;
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * boolean param_1 = obj.insert(val);
 * boolean param_2 = obj.remove(val);
 * int param_3 = obj.getRandom();
 */
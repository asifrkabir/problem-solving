class Solution {
    public String mergeAlternately(String word1, String word2) {
        StringBuilder sb = new StringBuilder();
        int word1Length = word1.length();
        int word2Length = word2.length();
        boolean word1Larger = word1Length >= word2Length;
        int iterateUpto = 1;

        if(word1Larger) {
            iterateUpto = word2Length;
        } else {
            iterateUpto = word1Length;
        }

        for(int i = 0; i < iterateUpto; i++) {
            sb.append(word1.charAt(i)).append(word2.charAt(i));
        }

        if(word1Larger) {
            sb.append(word1.substring(iterateUpto, word1Length));
        } else {
            sb.append(word2.substring(iterateUpto, word2Length));
        }

        return sb.toString();
    }
}
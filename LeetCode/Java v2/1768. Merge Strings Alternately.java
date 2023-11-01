class Solution {
    public String mergeAlternately(String word1, String word2) {
        StringBuilder sb = new StringBuilder();
        int length1 = word1.length();
        int length2 = word2.length();
        int i = 0;

        while(i < length1 && i < length2) {
            if(i < length1) {
                sb.append(word1.charAt(i));
            }
            if(i < length2) {
                sb.append(word2.charAt(i));
            }
            i++;
            if(i == length1) {
                sb.append(word2.substring(i));
                break;
            }
            if(i == length2) {
                sb.append(word1.substring(i));
                break;
            }
        }

        return sb.toString();
    }
}
class Solution {
    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;
        } else {
            int[] letterCountsForS = new int[26];
            int[] letterCountsForT = new int[26];

            for (int i = 0; i < s.length(); i++) {
                int indexAtS = s.charAt(i) - 'a';
                letterCountsForS[indexAtS]++;

                int indexAtT = t.charAt(i) - 'a';
                letterCountsForT[indexAtT]++;
            }

            boolean result = true;

            for (int i = 0; i < 26; i++) {
                if (letterCountsForS[i] != letterCountsForT[i]) {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
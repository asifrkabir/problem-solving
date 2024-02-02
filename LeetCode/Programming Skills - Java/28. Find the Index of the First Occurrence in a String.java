class Solution {
    public int strStr(String haystack, String needle) {
        int index = -1;
        int needleLength = needle.length();
        int iterateUpto = haystack.length() - needleLength;

        for (int i = 0; i <= iterateUpto; i++) {
            if (haystack.substring(i, i + needleLength).equals(needle)) {
                index = i;
                break;
            }
        }

        return index;
    }
}
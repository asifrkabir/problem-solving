class Solution {
    public boolean repeatedSubstringPattern(String s) {
        String concatenatedString = s + s;
        String substring = concatenatedString.substring(1, concatenatedString.length() - 1);
        return substring.contains(s);
    }
}
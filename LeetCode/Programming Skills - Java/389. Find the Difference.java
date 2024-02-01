class Solution {
    public char findTheDifference(String s, String t) {
        int lengthOfS = s.length();

        if (lengthOfS == 0) {
            return t.charAt(0);
        }

        char newCharacter = 0;

        for (char characterInS : s.toCharArray()) {
            newCharacter ^= characterInS;
        }

        for (char characterInT : t.toCharArray()) {
            newCharacter ^= characterInT;
        }

        return newCharacter;
    }
}
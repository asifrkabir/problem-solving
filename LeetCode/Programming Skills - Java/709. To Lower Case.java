class Solution {
    public String toLowerCase(String s) {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.length(); i++) {
            char c = s.charAt(i);
            int code = c;

            if (code >= 65 && code <= 90) {
                code += 32;
                c = (char) code;
            }

            sb.append(c);
        }

        return sb.toString();
    }
}
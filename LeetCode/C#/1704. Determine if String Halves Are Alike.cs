public class Solution {
    public bool HalvesAreAlike(string s) {
        var count = 0;
        
        for(int i = 0, j = s.Length / 2; i < s.Length / 2; i++, j++)
        {
            if(checkVowel(s[i])) count++;
            if(checkVowel(s[j])) count--;
        }
        
        return (count == 0);
    }
    
    public bool checkVowel(char c) {
        char[] vowelArray = new char[]{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        
        return vowelArray.Contains(c);
    }
}
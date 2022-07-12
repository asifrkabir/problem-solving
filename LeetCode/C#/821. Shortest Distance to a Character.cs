public class Solution {
    public int[] ShortestToChar(string s, char c) {
        var answer = new int[s.Length];
        var charIndices = new List<int>();
        
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == c)
            {
                charIndices.Add(i);
            }
        }
        
        var currentCharIndex = 0;
        
        for(var i = 0; i < s.Length; i++)
        {
            if(s[i] == c)
            {
                answer[i] = 0;
                
                if(currentCharIndex < charIndices.Count - 1)
                {
                    currentCharIndex++;
                }
                
                continue;
            }
            
            if(currentCharIndex == 0)
            {
                answer[i] = Math.Abs(charIndices[currentCharIndex] - i);
            }
            else
            {
                answer[i] = Math.Min(Math.Abs(charIndices[currentCharIndex] - i), Math.Abs(charIndices[currentCharIndex - 1] - i));
            }
        }
        
        return answer;
    }
}
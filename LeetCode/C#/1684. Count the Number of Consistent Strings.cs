public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        var count = 0;
        
        var allowedArray = allowed.ToCharArray();
        
        for(var i = 0; i < words.Length; i++)
        {
            var letterContainCheck = true;
            
            foreach(var letter in words[i])
            {
                if(allowedArray.Contains(letter) == false)
                {
                    letterContainCheck = false;
                    break;
                }
            }
            
            if(letterContainCheck) count++;
        }
        
        return count;
    }
}
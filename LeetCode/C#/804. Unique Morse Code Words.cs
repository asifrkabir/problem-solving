public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        var morseCode = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        var transformationList = new List<string>();
        
        for(var i = 0; i < words.Length; i++)
        {
            var transformationString = "";
            
            foreach(var letter in words[i])
            {
                transformationString += morseCode[(int)letter - 97];
            }
            
            if(!transformationList.Contains(transformationString))
            {
                transformationList.Add(transformationString);
            }
        }
        
        return transformationList.Count;
    }
}
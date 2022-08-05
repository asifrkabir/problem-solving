public class Solution {
    public string[] FindWords(string[] words) {
//         var output = new List<string>();
//         var row1 = "qwertyuiop".ToCharArray();
//         var row2 = "asdfghjkl".ToCharArray();
//         var row3 = "zxcvbnm".ToCharArray();
        
//         foreach(var word in words)
//         {
//             var currentWord = word.ToLower();
//             var found1 = true;
//             var found2 = true;
//             var found3 = true;
            
//             foreach(var letter in currentWord)
//             {
//                 if(!row1.Contains(letter))
//                 {
//                     found1 = false;
//                     break;
//                 }
//             }
            
//             foreach(var letter in currentWord)
//             {
//                 if(!row2.Contains(letter))
//                 {
//                     found2 = false;
//                     break;
//                 }
//             }
            
//             foreach(var letter in currentWord)
//             {
//                 if(!row3.Contains(letter))
//                 {
//                     found3 = false;
//                     break;
//                 }
//             }
            
//             if(found1 || found2 || found3)
//             {
//                 output.Add(word);
//             }
//         }
        
//         return output.ToArray();
        
        var output = new List<string>();
        var row1 = new HashSet<char>("qwertyuiop".ToCharArray());
        var row2 = new HashSet<char>("asdfghjkl".ToCharArray());
        var row3 = new HashSet<char>("zxcvbnm".ToCharArray());
        
        foreach(var word in words)
        {
            var wordSet = new HashSet<char>(word.ToLower().ToCharArray());
            
            if(wordSet.IsSubsetOf(row1) || wordSet.IsSubsetOf(row2) || wordSet.IsSubsetOf(row3))
            {
                output.Add(word);
            }
        }
        
        return output.ToArray();
    }
}
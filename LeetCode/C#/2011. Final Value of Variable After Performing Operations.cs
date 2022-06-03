public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        var x = 0;
        
        for(var i = 0; i < operations.Length; i++){
            if(operations[i] == "--X" || operations[i] == "X--"){
                --x;
            }
            else{
                ++x;
            }
        }
        
        return x;
    }
}
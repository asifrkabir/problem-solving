public class Solution {
    public int MaximumWealth(int[][] accounts) {
        var maxWealth = 0;
        
        for(var i = 0; i < accounts.Length; i++){
            var currentWealth = 0;
            
            for(var j = 0; j < accounts[0].Length; j++){
                currentWealth += accounts[i][j];
            }
            
            if(currentWealth > maxWealth){
                maxWealth = currentWealth;
            }
        }
        
        return maxWealth;
    }
}
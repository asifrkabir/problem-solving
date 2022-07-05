public class Solution {
    public int[] SumZero(int n) {
        if(n == 1)
        {
            return new int[]{0};
        }
        
        List<int> numList = new List<int>();
        
        var rnd = new Random();
            
        for(var i = 0; i < n / 2; i++)
        {
            var num1 = rnd.Next();
                
            numList.Add(num1);
            numList.Add(num1 * -1);
        }
        
        if(n % 2 == 1)
        {
            numList.Add(0);
        }
        
        return numList.ToArray();
    }
}
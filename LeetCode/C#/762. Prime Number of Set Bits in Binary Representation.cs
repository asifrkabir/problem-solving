public class Solution {
    public int CountPrimeSetBits(int left, int right) {
        var count = 0;
        var binaryString = string.Empty;
        
        for(var i = left; i <= right; i++)
        {
            binaryString = Convert.ToString(i, 2);
            
            if(CheckSetBitsPrime(binaryString))
            {
                count++;
            }
        }
        
        return count;
    }
    
    public bool CheckSetBitsPrime(string s)
    {
        var primes = new int[]{2, 3, 5, 7, 11, 13, 17, 19};
        var setBits = 0;
        
        foreach(var digit in s)
        {
            if(digit == '1')
            {
                setBits++;
            }
        }
        
        return primes.Contains(setBits);
    }
}
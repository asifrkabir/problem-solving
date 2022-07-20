public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        if(arr.Length == 1)
        {
            return arr[0];
        }
        else if(arr.Length == 2)
        {
            return arr[0] + arr[1];
        }
        else
        {
            var sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                var currentSum = 0;
                var x = 1;
                
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    
                    if(x % 2 != 0)
                    {
                        sum += currentSum;
                    }
                    
                    x++;
                }
            }
            
            return sum;
        }
    }
}
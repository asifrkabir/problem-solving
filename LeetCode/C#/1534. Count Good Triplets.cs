public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        var tripletCount = 0;
        
        for(var i = 0; i < arr.Length - 2; i++)
        {
            for(var j = i + 1; j < arr.Length - 1; j++)
            {
                for(var k = j + 1; k < arr.Length; k++)
                {
                    if(Math.Abs(arr[i] - arr[j]) <= a 
                       && Math.Abs(arr[j] - arr[k]) <= b 
                       && Math.Abs(arr[i] - arr[k]) <= c) tripletCount++;
                }
            }
        }
        
        return tripletCount;
    }
}
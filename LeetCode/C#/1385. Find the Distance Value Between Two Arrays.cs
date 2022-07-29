public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        Array.Sort(arr2);
        
        var count = 0;
        
        for(var i = 0; i < arr1.Length; i++)
        {
            var left = 0;
            var right = arr2.Length - 1;
            
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                
                if(Math.Abs(arr1[i] - arr2[mid]) <= d)
                {
                    count++;
                    break;
                }
                
                if(arr1[i] < arr2[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }
        
        return arr1.Length - count;
    }
}
public class Solution {
    public int[] ReplaceElements(int[] arr) {
        if(arr.Length == 1) return new int[]{-1};
        
        var max = arr[arr.Length - 1];
        
        for(var i = arr.Length - 2; i >= 0; i--)
        {
            if(arr[i] > max)
            {
                var temp = max;
                max = arr[i];
                arr[i] = temp;
            }
            else
            {
                arr[i] = max;
            }
        }
        
        arr[arr.Length - 1] = -1;
        
        return arr;
    }
}
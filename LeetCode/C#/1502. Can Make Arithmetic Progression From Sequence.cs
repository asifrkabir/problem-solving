public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        var diff = arr[1] - arr[0];
        
        for(var i = 1; i < arr.Length - 1; i++)
        {
            if(arr[i + 1] - arr[i] != diff)
            {
                return false;
            }
        }
        
        return true;
    }
}
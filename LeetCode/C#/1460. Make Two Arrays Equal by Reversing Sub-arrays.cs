public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        if(Enumerable.SequenceEqual(target, arr) == true)
        {
            return true;
        }
        
        Array.Sort(target);
        Array.Sort(arr);
        
        return Enumerable.SequenceEqual(target, arr);
    }
}
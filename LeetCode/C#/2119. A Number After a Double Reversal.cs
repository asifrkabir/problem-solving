public class Solution {
    public bool IsSameAfterReversals(int num) {
        if(num == 0 || num % 10 != 0)
        {
            return true;
        }
        
        return false;
    }
}
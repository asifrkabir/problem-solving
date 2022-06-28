public class Solution {
    public bool SquareIsWhite(string coordinates) {
        if((int)coordinates[0] % 2 == 0)
        {
            if((int)coordinates[1] % 2 == 0) return false;
        }
        else
        {
            if((int)coordinates[1] % 2 != 0) return false;
        }
        
        return true;
    }
}
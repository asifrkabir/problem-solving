public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        var operations = new List<string>();
        
        for(int i = 1, j = 0; i <= n; i++)
        {
            if(j < target.Length)
            {
                if(target[j] == i)
                {
                    operations.Add("Push");
                    j++;
                }
                else
                {
                    operations.Add("Push");
                    operations.Add("Pop");
                }
            }
            else
            {
                break;
            }
        }
        
        return operations;
    }
}
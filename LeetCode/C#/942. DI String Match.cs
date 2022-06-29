public class Solution {
    public int[] DiStringMatch(string s) {
        var perm = new int[s.Length + 1];
        
        var head = 0;
        var tail = s.Length;
        
        for(var i = 0; i < perm.Length - 1; i++)
        {
            if(s[i] == 'I')
            {
                perm[i] = head++;
            }
            else
            {
                perm[i] = tail--;
            }
        }
        
        perm[^1] = head;
        
        return perm;
    }
}
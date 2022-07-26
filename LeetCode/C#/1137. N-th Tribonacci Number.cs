public class Solution {
    public int Tribonacci(int n) {
//         if(n == 0 || n == 1)
//         {
//             return n;
//         }
        
//         if(n == 2)
//         {
//             return 1;
//         }
        
//         return Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
        
        if(n == 0 || n == 1)
        {
            return n;
        }
        else if(n == 2)
        {
            return 1;
        }
        else
        {
            var arr = new int[38];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;
            
            for(var i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 3] + arr[i - 2] + arr[i - 1];
            }
            
            return arr[n];
        }
    }
}
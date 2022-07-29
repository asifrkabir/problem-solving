/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */

public class Solution {
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z) {
        var ansList = new List<IList<int>>();
        var x = 1;
        var y = 1000;
        
        while(x <= 1000 && y >= 1)
        {
            var solution = customfunction.f(x, y);
            
            if(solution == z)
            {
                var l1 = new List<int>(){x, y};
                ansList.Add(l1);
                x++;
                y--;
            }
            else if(solution < z)
            {
                x++;
            }
            else
            {
                y--;
            }
        }
        
        return ansList;
    }
}
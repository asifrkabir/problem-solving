public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var numList = new List<int>();
        var numString = string.Empty;
        var nonDividing = false;
        
        for(var i = left; i <= right; i++)
        {
            numString = i.ToString();
            nonDividing = false;
            
            if(!numString.Contains('0'))
            {
                foreach(var digit in numString)
                {
                    if(i % (digit - '0') != 0)
                    {
                        nonDividing = true;
                        break;
                    }
                }
                
                if(!nonDividing)
                {
                    numList.Add(i);
                }
            }
        }
        
        return numList;
    }
}
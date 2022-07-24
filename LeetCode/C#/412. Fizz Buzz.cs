public class Solution {
    public IList<string> FizzBuzz(int n) {
        var answer = new List<string>();
        
        for(var i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                answer.Add("FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                answer.Add("Fizz");
            }
            else if(i % 5 == 0)
            {
                answer.Add("Buzz");
            }
            else
            {
                answer.Add(i.ToString());
            }
        }
        
        return answer;
    }
}
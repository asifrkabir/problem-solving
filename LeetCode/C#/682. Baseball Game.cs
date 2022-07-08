public class Solution {
    public int CalPoints(string[] ops) {
        var score = 0;     
        var scoreStack = new Stack<int>();
        
        for(var i = 0; i < ops.Length; i++)
        {
            if(ops[i].Equals("+"))
            {
                var num1 = scoreStack.Pop();
                var num2 = scoreStack.Peek();
                var sum = num1 + num2;
                scoreStack.Push(num1);
                scoreStack.Push(sum);
            }
            else if(ops[i].Equals("D"))
            {
                scoreStack.Push(scoreStack.Peek() * 2);
            }
            else if(ops[i].Equals("C"))
            {
                score -= scoreStack.Pop();
                continue;
            }
            else{
                scoreStack.Push(int.Parse(ops[i]));
            }
            
            score += scoreStack.Peek();
        }
        
        return score;
    }
}
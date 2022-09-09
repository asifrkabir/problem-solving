public class Solution
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var studentQueue = new Queue<int>(students);
        var sandwichStack = new Stack<int>();

        for (var i = sandwiches.Length - 1; i >= 0; i--)
        {
            sandwichStack.Push(sandwiches[i]);
        }

        while (true)
        {
            if (studentQueue.Contains(sandwichStack.Peek()))
            {
                if (studentQueue.Peek() == sandwichStack.Peek())
                {
                    studentQueue.Dequeue();
                    sandwichStack.Pop();

                    if (sandwichStack.Count == 0)
                    {
                        break;
                    }
                }
                else
                {
                    studentQueue.Enqueue(studentQueue.Peek());
                    studentQueue.Dequeue();
                }
            }
            else
            {
                break;
            }
        }

        return studentQueue.Count;
    }
}
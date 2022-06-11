public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        var minMoves = 0;
        
        Array.Sort(seats);
        Array.Sort(students);
        
        for(var i = 0; i < seats.Length; i++)
        {
            minMoves += Math.Abs(seats[i] - students[i]);
        }
        
        return minMoves;
    }
}
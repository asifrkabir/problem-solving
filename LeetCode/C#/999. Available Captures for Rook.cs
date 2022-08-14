public class Solution {
    public int NumRookCaptures(char[][] board) {
        var rookX = 0;
        var rookY = 0;
        var captures = 0;
        
        for(var i = 0; i < board.Length; i++)
        {
            for(var j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] == 'R')
                {
                    rookX = i;
                    rookY = j;
                    break;
                }
            }
        }
        
        // west
        
        for(var i = rookY - 1; i >= 0; i--)
        {
            if(board[rookX][i] == 'B')
            {
                break;
            }
            else if(board[rookX][i] == 'p')
            {
                captures++;
                break;
            }
        }
        
        // east
        
        for(var i = rookY + 1; i < board[0].Length; i++)
        {
            if(board[rookX][i] == 'B')
            {
                break;
            }
            else if(board[rookX][i] == 'p')
            {
                captures++;
                break;
            }
        }
        
        // north
        
        for(var i = rookX - 1; i >= 0; i--)
        {
            if(board[i][rookY] == 'B')
            {
                break;
            }
            else if(board[i][rookY] == 'p')
            {
                captures++;
                break;
            }
        }
        
        // south
        
        for(var i = rookX + 1; i < board.Length; i++)
        {
            if(board[i][rookY] == 'B')
            {
                break;
            }
            else if(board[i][rookY] == 'p')
            {
                captures++;
                break;
            }
        }
        
        return captures;
    }
}
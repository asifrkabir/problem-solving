public class Solution {
    public string Interpret(string command) {
        var interpretedCommand = "";
        
        for(var i = 0; i < command.Length;)
        {
            if(string.Equals(command[i], 'G'))
            {
                interpretedCommand += 'G';
                i++;
            }
            else
            {
                if(string.Equals(command[i+1], ')'))
                {
                    interpretedCommand += 'o';
                    i += 2;
                }
                else{
                    interpretedCommand += "al";
                    i += 4;
                }
            }
        }
        
        return interpretedCommand;
    }
}
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> ansList = new List<IList<int>>();

        if(numRows == 0)
        {
            return ansList;
        }

        ansList.Add(new List<int>(){1});

        if(numRows == 1)
        {
            return ansList;
        }

        ansList.Add(new List<int>(){1, 1});

        if(numRows == 2)
        {
            return ansList;
        }

        for(var i = 1; i < numRows - 1; i++)
        {
            List<int> tempList = new List<int>();
            tempList.Add(1);

            for(var j = 0; j < ansList[i].Count() - 1; j++)
            {
                tempList.Add(ansList[i][j] + ansList[i][j + 1]);
            }

            tempList.Add(1);
            ansList.Add(tempList);
        }

        return ansList;
    }
}
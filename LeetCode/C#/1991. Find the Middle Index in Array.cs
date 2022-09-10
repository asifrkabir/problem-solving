public class Solution
{
    public int FindMiddleIndex(int[] nums)
    {
        var middleIndex = -1;
        var prefixSumArr = new int[nums.Length];
        prefixSumArr[0] = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            prefixSumArr[i] = prefixSumArr[i - 1] + nums[i];
        }

        for (var i = 0; i < nums.Length; i++)
        {
            var leftSum = 0;
            var rightSum = 0;

            if (i == 0)
            {
                leftSum = 0;
                rightSum = prefixSumArr[prefixSumArr.Length - 1] - prefixSumArr[0];
            }
            else if (i == prefixSumArr.Length - 1)
            {
                leftSum = prefixSumArr[prefixSumArr.Length - 2];
                rightSum = 0;
            }
            else
            {
                leftSum = prefixSumArr[i - 1];
                rightSum = prefixSumArr[prefixSumArr.Length - 1] - prefixSumArr[i];
            }

            if (leftSum == rightSum)
            {
                middleIndex = i;
                break;
            }
        }

        return middleIndex;
    }
}
public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        for(var i = 0; i < nums.Length; i++)
        {
            if(i % 2 == 0)
            {
                if(nums[i] % 2 == 0)
                {
                    continue;
                }
                else
                {
                    for(var j = i + 1; j < nums.Length; j++)
                    {
                        if(nums[j] % 2 == 0)
                        {
                            var temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }
            else
            {
                if(nums[i] % 2 != 0)
                {
                    continue;
                }
                else
                {
                    for(var j = i + 1; j < nums.Length; j++)
                    {
                        if(nums[j] % 2 != 0)
                        {
                            var temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }
        }
        
        return nums;
    }
}
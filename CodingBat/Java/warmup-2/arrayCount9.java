public int arrayCount9(int[] nums) {
  int count = 0;
  
  if(nums.length == 0) return count;
  
  for(int i = 0; i < nums.length; i++){
    if(nums[i] == 9) count++;
  }
  
  return count;
}
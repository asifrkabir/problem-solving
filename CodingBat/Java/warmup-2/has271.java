public boolean has271(int[] nums) {
  for(int i = 0; i < nums.length - 2; i++){
    if((nums[i + 1] - nums[i] == 5) && (nums[i] - nums[i + 2] <= 2 && nums[i] - nums[i + 2] >= 0)){
      return true;
    }
  }
  
  return false;
}
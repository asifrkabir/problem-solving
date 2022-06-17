public boolean arrayFront9(int[] nums) {
  int size;
  
  if(nums.length > 4) size = 4;
  else size = nums.length;
  
  for(int i = 0; i < size; i++){
      if(nums[i] == 9) return true;
  }
  
  return false;
}
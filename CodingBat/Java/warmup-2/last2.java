public int last2(String str) {
  if(str.length() <= 1) return 0;
  
  int count = 0;
  String subStr = str.substring(str.length() - 2, str.length());
  
  for(int i = 0; i < str.length() - 2; i++){
    if(str.substring(i, i + 2).equals(subStr)) count++;
  }
  
  return count;
}
public int stringMatch(String a, String b) {
  int count = 0;
  int end;
  
  if(a.length() <= b.length()) end = a.length();
  else end = b.length();
  
  for(int i = 0; i < end - 1; i++){
    if(a.substring(i, i + 2).equals(b.substring(i, i + 2))) count++;
  }
  
  return count;
}
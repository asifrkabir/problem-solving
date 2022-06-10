public int countAbc(String str) {
  if(str.length() <= 2 || !str.contains("ab") || !str.contains("ab")) return 0;
  
  if(str.substring(0, 3).equals("abc")){
    return 1 + countAbc(str.substring(3));
  }
  
  if(str.substring(0, 3).equals("aba")){
    return 1 + countAbc(str.substring(2));
  }
  
  return 0 + countAbc(str.substring(1));
}
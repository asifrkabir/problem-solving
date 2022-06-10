public int countHi(String str) {
  if(str.length() == 0) return 0;
  
  if(!str.contains("hi")) return 0;
  
  if(str.charAt(str.length() - 1) == 'i' && str.charAt(str.length() - 2) == 'h'){
    return 1 + countHi(str.substring(0, str.length() - 2));
  }
  
  return countHi(str.substring(0, str.length() - 1));
}
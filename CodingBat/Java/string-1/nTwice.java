public String nTwice(String str, int n) {
  if(str.length() <= 2) return str;
  
  return str.substring(0, n) + str.substring(str.length() - n);
}
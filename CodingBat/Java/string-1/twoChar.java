public String twoChar(String str, int index) {
  if(index < 0 || index >= str.length() - 1) return str.substring(0, 2);
  
  return str.substring(index, index + 2);
}
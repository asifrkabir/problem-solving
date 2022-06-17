boolean doubleX(String str) {
  
  int xIndex = str.indexOf("x");
  
  if(xIndex == -1 || xIndex == str.length() - 1) return false;
  
  if(str.charAt(xIndex + 1) == 'x') return true;
  
  return false;
}
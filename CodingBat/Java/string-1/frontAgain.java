public boolean frontAgain(String str) {
  if(str.length() <= 1) return false;
  
  if(str.substring(0, 2).equals(str.substring(str.length() - 2))) return true;
  
  return false;
}
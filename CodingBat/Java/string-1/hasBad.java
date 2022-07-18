public boolean hasBad(String str) {
  if(str.length() < 3) return false;
  
  if(str.length() == 3){
    return str.substring(0, 3).equals("bad");
  }
  
  return str.substring(0, 3).equals("bad") || str.substring(1, 4).equals("bad");
}
public String endX(String str) {
  if(str.length() == 0 || !str.contains("x")) return str;
  
  if(str.charAt(0) == 'x'){
    return endX(str.substring(1)) + "x";
  }
  
  return String.valueOf(str.charAt(0)) + endX(str.substring(1));
}
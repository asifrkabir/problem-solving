public String noX(String str) {
  if(str.length() == 0 || !str.contains("x")) return str;
  
  if(str.charAt(0) == 'x') return noX(str.substring(1));
  
  return String.valueOf(str.charAt(0)) + noX(str.substring(1));
}
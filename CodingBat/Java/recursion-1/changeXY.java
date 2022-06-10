public String changeXY(String str) {
  if(str.length() == 0 || !str.contains("x")) return str;
  
  if(str.length() == 1){
    if(str.charAt(0) == 'x') return "y";
    return str;
  }
  
  if(str.charAt(0) == 'x'){
    return "y" + changeXY(str.substring(1));
  }
  
  return String.valueOf(str.charAt(0)) + changeXY(str.substring(1));
}
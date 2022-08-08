public String withoutX(String str) {
  if(str.length() == 0) return "";
  
  if(str.length() == 1){
    if(str.equals("x")) return "";
    return str;
  }
  
  if(str.charAt(0) == 'x'){
    if(str.charAt(str.length() - 1) == 'x'){
      return str.substring(1, str.length() - 1);
    }
    
    return str.substring(1);
  }
  
  if(str.charAt(str.length() - 1) == 'x'){
    return str.substring(0, str.length() - 1);
  }
  
  return str;
}
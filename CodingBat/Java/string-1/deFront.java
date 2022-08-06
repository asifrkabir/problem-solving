public String deFront(String str) {    
  if(str.length() == 0) return "";
  
  if(str.length() == 1){
    if(str.equals("a")) return str;
    return "";
  }
  
  boolean firstCharCheck = str.charAt(0) == 'a';
  boolean secondCharCheck = str.charAt(1) == 'b';
  
  if(firstCharCheck && secondCharCheck) return str;
  else if(firstCharCheck && !secondCharCheck){
    return "a" + str.substring(2);
  }
  else if(!firstCharCheck && secondCharCheck){
    return str.substring(1);
  }
  else return str.substring(2);
}